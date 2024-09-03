using AutoMapper;
using AutoMapper.Configuration.Conventions;
using Common;
using ECommerce.AppAdmin.Filter;
using Entity.AppModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using static Common.DataEnum;

namespace ECommerce.AppAdmin.Controllers
{
    public class ProductController : Controller
    {
        private readonly UnitOfWork UOW;
        private readonly IMapper mapper;
        public ProductController(UnitOfWork uow,IMapper mapper)
        {
            UOW = uow;
            this.mapper = mapper;
        }
        [Authorize((int)AccessLevelEnum.ViewAccess)]
        public IActionResult Index()
        {
            return View(UOW.ProductRepository.GetAll());
        }
        [Authorize((int)AccessLevelEnum.ControlAccess)]
        public IActionResult CreateOrEdit(int id = 0)
        {
            Product product = new Product(); 
            if (id > 0)
            {
                product = UOW.ProductRepository.GetById(id);
                if(product == null)
                {
                    return NotFound();
                }
            }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrEdit( int id,Product product)
        {
            try
            {
                if (id > 0)
                {
                    Product data = UOW.ProductRepository.GetById(id);
                    mapper.Map(product, data);
                    UOW.ProductRepository.UpdateEntity(data);
                    UOW.ProductRepository.Save();
                }
                else
                {
                    product.Cover = "";
                    UOW.ProductRepository.CreateEntity(product);
                    UOW.ProductRepository.Save();
                    IFormFile file =HttpContext.Request.Form.Files["ImageFile"];
                    if (file != null)
                    {
                        ImageManager imageManager = new ImageManager(AppMainData.WebRootPath);
                        string imgName = await imageManager.UploadImageAsync(AppMainData.DomainName, file, "ProductImages");
                        if (!string.IsNullOrEmpty(imgName))
                        {
                            product.Cover = imgName;
                            UOW.ProductRepository.UpdateEntity(product);
                            UOW.ProductRepository.Save();
                        }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UOW.ProductRepository.Any(x => x.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }
        [Authorize((int)AccessLevelEnum.ViewAccess)]
        public IActionResult Details(int id)
        {
            Product product = UOW.ProductRepository.GetById(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [Authorize((int)AccessLevelEnum.FullAccess)]
        public IActionResult Delete(int id)
        {
            Product product = UOW.ProductRepository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult confirmDelete(int id)
        {
            Product product = UOW.ProductRepository.GetById(id);
            UOW.ProductRepository.DeleteEntity(product);
            UOW.ProductRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
