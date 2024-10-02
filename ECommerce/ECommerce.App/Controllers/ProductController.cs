using Microsoft.AspNetCore.Mvc;
using Repository;

namespace ECommerce.App.Controllers
{
    public class ProductController : Controller
    {
        private readonly UnitOfWork UOW;
        public ProductController(UnitOfWork UOW)
        {
            this.UOW = UOW;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductDetails(int id)
        {

            return View(UOW.ProductRepository.GetById(id));
        }
        public IActionResult AddToCart()
        {
            return View();
        }
    }
}
