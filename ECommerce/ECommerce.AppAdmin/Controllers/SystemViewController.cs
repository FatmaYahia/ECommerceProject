using AutoMapper;
using ECommerce.AppAdmin.Filter;
using Entity.AuthModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.AuthRepository;
using static Common.DataEnum;

namespace ECommerce.AppAdmin.Controllers
{
    public class SystemViewController : Controller
    {
        private readonly UnitOfWork UOW;
        private readonly IMapper mapper;
        public SystemViewController(UnitOfWork UOW,IMapper mapper)
        {

            this.UOW = UOW;
            this.mapper = mapper;
        }
        [Authorize((int)AccessLevelEnum.ViewAccess)]
        public IActionResult Index()
        {
            return View(UOW.SystemViewRepository.GetAll());
        }
        [Authorize((int)AccessLevelEnum.ControlAccess)]
        public IActionResult CreateOrEdit(int id = 0)
        {
            SystemView systemView = new SystemView();
            if (id > 0) 
            {
                systemView = UOW.SystemViewRepository.GetById(id);
                if (systemView == null)
                {
                    return NotFound();
                }
            }
            return View(systemView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrEdit(int id,SystemView systemView)
        {
          
            try
            {
                if (id != systemView.Id)
                {
                    return NotFound();
                }
                if (id > 0)
                {
                    SystemView Data = UOW.SystemViewRepository.GetById(id);
                    mapper.Map(systemView, Data);
                    UOW.SystemViewRepository.UpdateEntity(Data);
                    UOW.SystemViewRepository.Save();
                }
                else
                {
                    UOW.SystemViewRepository.CreateEntity(systemView);
                    UOW.SystemViewRepository.Save();
                }
            }
            catch (DbUpdateConcurrencyException)
            {

                if (UOW.SystemViewRepository.Any(x => x.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));

        }
        [Authorize((int)AccessLevelEnum.ViewAccess)]
        public IActionResult Details(int id)
        {
            SystemView systemView = UOW.SystemViewRepository.GetById(id);
            if (systemView == null)
            {
                return NotFound();
            }
            return View(systemView);
        }
        [Authorize((int)AccessLevelEnum.FullAccess)]
        public IActionResult Delete(int id)
        {
            SystemView systemView = UOW.SystemViewRepository.GetById(id);
            if(systemView == null)
            {
                return NotFound();
                
            }
            ViewBag.canDelete = true;
            if (Enum.IsDefined(typeof(SystemViewEnum), id))
            {
                 ViewBag.canDelete = false;

            }
            return View(systemView);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult confirmDelete(int id)
        {
            SystemView systemView = UOW.SystemViewRepository.GetById(id);
            UOW.SystemViewRepository.DeleteEntity(systemView);
            UOW.SystemViewRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
