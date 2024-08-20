using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Repository;

namespace ECommerce.AppAdmin.Filter
{
    public class AuthorizeActionFilter : IActionFilter
    {
        private readonly int fk_AccessLevel;
        private readonly ISession session;
        private string Email;
        private readonly UnitOfWork UOW;
        private string viewName;
        public AuthorizeActionFilter(int fk_accessLevel,IHttpContextAccessor httpContextAccessor,UnitOfWork uow)
        {
            this.fk_AccessLevel = fk_accessLevel;
            session = httpContextAccessor.HttpContext.Session;
            UOW=uow;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Email = session.GetString("Email");
            viewName = context.RouteData.Values["controller"].ToString();
            if (string.IsNullOrEmpty(Email))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
            }
            else
            {
                if(!UOW.SystemUserPermissionRepository.checkAuthorization(fk_AccessLevel,Email,viewName))
                {

                    context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Home", action = "Error" }));
                 } 
            }
        }
    }
    public class AuthorizeAttribute:TypeFilterAttribute
    {
        public AuthorizeAttribute(int Fk_AccessLevel):base(typeof(AuthorizeActionFilter))
        {
            Arguments = new object[] { Fk_AccessLevel };
        }
    }
}
