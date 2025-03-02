using AutoMapper;
using Entity.AppModel;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace ECommerce.App.Controllers
{
    public class UserController : Controller
    {
        private readonly UnitOfWork UOW;
        public UserController(UnitOfWork uow)
        {
            UOW = uow;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            User user = new User();
            return View(user);
        }
        public IActionResult Register(User user)
        {
            try
            {
                UOW.UserRepository.CreateEntity(user);
                UOW.UserRepository.Save();
                }
            catch
            {

            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
