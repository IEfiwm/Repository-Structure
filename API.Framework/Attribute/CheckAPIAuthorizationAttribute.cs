using Contract.Base.Messaging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace API.Framework.Attribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CheckAPIAuthorizationAttribute : ActionFilterAttribute
    {
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (string.IsNullOrEmpty(context.HttpContext.Request.Headers["ApiKey"].ToString()) ||
                string.IsNullOrEmpty(context.HttpContext.Request.Headers["UserKey"].ToString()))
            {
                context.HttpContext.Response.StatusCode = 401;

                var response = new BaseApiResponse();

                response.AccessDenied();

                response.Failed();

                response.FailedMessage("دسترسی محدود شده است.");

                await context.HttpContext.Response.WriteAsJsonAsync(response);
            }
            await next();
        }
    }
}