using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Exercise.Controllers
{
    public class OnlyUnauthenticatedAttribute : TypeFilterAttribute
    {
        public OnlyUnauthenticatedAttribute() : base(typeof(MyFilter))
        {

        }

        private class MyFilter : IAuthorizationFilter
        {
            public void OnAuthorization(AuthorizationFilterContext authorizationFilterContext) { 
                if (authorizationFilterContext.HttpContext.User.Identity.IsAuthenticated)
                {
                    authorizationFilterContext.Result = new RedirectToActionResult("Index", "Product", null);
                }
            }
        }
        
    }
}
