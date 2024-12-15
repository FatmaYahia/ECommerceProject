using Entity.AppModel;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.App.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            User user = new User();
            return View(user);
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
