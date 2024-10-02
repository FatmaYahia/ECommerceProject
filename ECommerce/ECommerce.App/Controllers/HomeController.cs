using ECommerce.App.Models;
using Entity.AppModel;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Diagnostics;

namespace ECommerce.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnitOfWork UOW;

        public HomeController(ILogger<HomeController> logger,UnitOfWork _UOW)
        {
            _logger = logger;
            UOW=_UOW;
        }

        public IActionResult Index()
        {
            List<Product> products = UOW.ProductRepository.GetAll().OrderByDescending(x=>x.Offer).ToList(); 
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}