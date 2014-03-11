using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapV3Template.Common
{
    public class NavigationBar : ActionFilterAttribute, IActionFilter
    {
        public string ActiveNavBarItem { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Items["ActiveNavBarItem"] = ActiveNavBarItem;
            //throw new NotImplementedException();
        }
    }
}