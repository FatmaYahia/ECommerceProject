using Microsoft.AspNetCore.Mvc;
using Repository;

namespace ECommerce.AppAdmin.Controllers
{
    public class LoginController : Controller
    {
        private readonly UnitOfWork UOW;
        public LoginController(UnitOfWork UOW)
        {
            this.UOW= UOW;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
