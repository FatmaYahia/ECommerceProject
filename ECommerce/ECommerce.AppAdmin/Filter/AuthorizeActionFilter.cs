using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ECommerce.AppAdmin.Filter
{
    public class AuthorizeActionFilter : IActionFilter
    {
        private readonly int fk_AccessLevel;
        private readonly ISession session;
        private string Email;
        
        public AuthorizeActionFilter(int fk_accessLevel,IHttpContextAccessor httpContextAccessor)
        {
            this.fk_AccessLevel = fk_accessLevel;
            session = httpContextAccessor.HttpContext.Session;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Email = session.GetString("Email");
            if (string.IsNullOrEmpty(Email))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
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
