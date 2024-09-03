using ECommerce.AppAdmin.Filter;
using Microsoft.AspNetCore.Mvc;
using Repository;
using static Common.DataEnum;

namespace ECommerce.AppAdmin.Controllers
{
    public class OrderController : Controller
    {
        private readonly UnitOfWork UOW;
        public OrderController(UnitOfWork uow)
        {
            UOW = uow;
        }
        [Authorize((int)AccessLevelEnum.ViewAccess)]
        public IActionResult Index()
        {
            return View(UOW.OrderRepository.GetAll());
        }

    }
}
