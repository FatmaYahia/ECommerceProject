using AutoMapper;
using Entity.AuthModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace ECommerce.AppAdmin.Controllers
{
    public class LoginController : Controller
    {
        private readonly UnitOfWork UOW;
        private readonly ISession session;
        private readonly IMapper mapper;
        public LoginController(UnitOfWork UOW,IHttpContextAccessor HttpContextAccessor,IMapper mapper)
        {
            this.UOW= UOW;
            session = HttpContextAccessor.HttpContext.Session;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            session.Clear();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SystemUser systemUser)
        {
            try
            {
                if(UOW.SystemUserRepository.userExist(systemUser.Email, systemUser.Password))
                {
                    SystemUser user = UOW.SystemUserRepository.getByEmail(systemUser.Email);
                    session.SetString("Email", user.Email);
                    session.SetString("FullName", user.FullName);
                    session.SetString("JobTitle", user.JobTitle);
                    setViews(systemUser.Email);
                    return RedirectToAction(nameof(Index), "Home");
                }
                else
                {
                    ViewData["Error"] = "Invalid UserName Or Password";
                    return View(systemUser);
                }
            }
            catch(DbUpdateConcurrencyException)
            {
                if (!UOW.SystemUserRepository.userExist(systemUser.Email))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }  
        public IActionResult Edit()
        {
            string Email = session.GetString("Email");
            if(Email == null)
            {
                return NotFound();
            }
            SystemUser systemUser = UOW.SystemUserRepository.getByEmail(Email);
            return View(systemUser);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SystemUser systemUser)
        {
           try
            {
                SystemUser Data = UOW.SystemUserRepository.GetById(systemUser.Id);
                mapper.Map(systemUser, Data);
                UOW.SystemUserRepository.UpdateEntity(Data);
                UOW.SystemUserRepository.Save();
                session.SetString("Email", systemUser.Email);
                return RedirectToAction(nameof(Index),"Home");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UOW.SystemUserRepository.userExist(systemUser.Email))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            
        }
        public IActionResult Logout()
        {
            return RedirectToAction(nameof(Index));
        }
        public void setViews(string Email)
        {
            SystemUser systemUser = UOW.SystemUserRepository.getByEmail(Email);
            List<SystemView> systemViews= UOW.SystemViewRepository.getSystemUserViews(systemUser.Id);
            if (systemViews.Any())
            {
                List<string> Views=systemViews.Select(x=>x.Name).ToList();
                foreach(var view in Views)
                {
                    session.SetString(view, view);
                }
            }
        }
    }
}
