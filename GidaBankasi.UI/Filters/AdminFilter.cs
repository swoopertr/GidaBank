using System;
using GidaBankasi.UI.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebCore.Extension;

namespace GidaBankasi.UI.Filters
{
    public class AdminFilter : Attribute, IActionFilter
    
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var loginType = context.HttpContext.Session.GetObjectFromJson<int>("login_type");
            if (loginType != UserTypes.Admin.GetHashCode())
            {
                context.Result = new RedirectToActionResult("Login", "admin",null);
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }
    }
}