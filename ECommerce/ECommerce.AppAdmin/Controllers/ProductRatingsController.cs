using ECommerce.AppAdmin.Filter;
using Microsoft.AspNetCore.Mvc;
using Repository;
using static Common.DataEnum;

namespace ECommerce.AppAdmin.Controllers
{
    public class ProductRatingsController : Controller
    {
        private readonly UnitOfWork UOW;
        public ProductRatingsController(UnitOfWork uow)
        {
            UOW = uow;
        }
        [Authorize((int)AccessLevelEnum.ViewAccess)]
        public IActionResult Index()
        {
            return View(UOW.ProductRatingsRepository.GetAll());
        }
    }
}
