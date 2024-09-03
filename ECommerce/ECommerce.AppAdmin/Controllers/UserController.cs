using ECommerce.AppAdmin.Filter;
using Microsoft.AspNetCore.Mvc;
using Repository;
using static Common.DataEnum;

namespace ECommerce.AppAdmin.Controllers
{
    public class UserController : Controller
    {
        private readonly UnitOfWork UOW;
        public UserController(UnitOfWork uow)
        {
            UOW = uow;
        }
        [Authorize((int)AccessLevelEnum.ViewAccess)]
        public IActionResult Index()
        {
            return View(UOW.UserRepository.GetAll());
        }
    }
}
