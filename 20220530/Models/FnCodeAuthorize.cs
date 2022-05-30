using _20220530.Models.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _20220530.Models
{
    public class FnCodeAuthorize : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly AuthFnCodeEnum AuthFnCode;
        public FnCodeAuthorize(AuthFnCodeEnum authFnCode)
        {
            this.AuthFnCode = authFnCode;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var isAuthenticated = context.HttpContext.User.Identity.IsAuthenticated;
            if (!isAuthenticated)
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var userAuthFnCode = context.HttpContext.User.FindFirst("AuthFnCode").Value.Split(',');
            var isAuth = userAuthFnCode.Contains(AuthFnCode.ToString());
            if (!isAuth)
            {
                context.Result = new ForbidResult();
                return;
            }
        }
    }
}
