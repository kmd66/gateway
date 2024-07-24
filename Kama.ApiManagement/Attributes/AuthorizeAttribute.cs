using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Kama.ApiManagement.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    string log = "";
    public async void OnAuthorization(AuthorizationFilterContext context)
    {
        if (checkAuthorize(context.ActionDescriptor as ControllerActionDescriptor))
        {
            string authorizationClaims = context.HttpContext.Request.Headers["AuthorizationClaims"];
            if (authorizationClaims == null)
            {
                context.Result = new UnauthorizedResult();
                return;
            }
        }
    }

    private bool checkAuthorize(ControllerActionDescriptor controllerActionDescriptor)
    {
        if (controllerActionDescriptor != null)
        {
            var ControllerChecking = controllerActionDescriptor.ControllerTypeInfo.CustomAttributes.Where(w => w.AttributeType.Name.Contains("AllowAnonymous")).ToList();
            if (ControllerChecking.Count > 0)
                return false;
            var ActionChecking = controllerActionDescriptor.MethodInfo.CustomAttributes.Where(w => w.AttributeType.Name.Contains("AllowAnonymous")).ToList();
            if (ActionChecking.Count > 0)
                return false;
        }

        return true;
    }

}
//public class SetAuthorizationHederAttribute : ActionFilterAttribute
//{
//    public virtual void OnActionExecuting(ActionExecutingContext context)
//    {
//        string authHeader = context.HttpContext.Request.Headers["Authorization"];
//    }

//    public virtual void OnActionExecuted(ActionExecutedContext context)
//    {
//        throw null;
//    }

//}