using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapV3Template.Common
{

    public class NavBarItem
    {
        public string Name { get; set; }
        public string IconClass { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        //public string Href { get; set; }
    }
    public static class Settings
    {
        public static List<NavBarItem> NavBarItems()
        {
            var result = new List<NavBarItem>();
            result.Add(new NavBarItem{ Name = "Home", IconClass = "fa fa-home", Controller = "Home", Action = "Index" });
            result.Add(new NavBarItem { Name = "Styles", IconClass = "fa fa-dashboard", Controller = "Home", Action = "Styles" });
            result.Add(new NavBarItem { Name = "Components", IconClass = "fa fa-gear", Controller = "Home", Action = "Components" });
            return result;
        }
    }
    
    public static class HtmlExtensions
    {
        public static MvcHtmlString RenderNavigation(this HtmlHelper helper)
        {
            var container = new TagBuilder("ul");
            container.AddCssClass("nav navbar-nav");

            var activeNavBarItem = HttpContext.Current.Items["ActiveNavBarItem"].ToString();

            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
            foreach (var item in Settings.NavBarItems())
            {
                var url = urlHelper.Action(item.Action, item.Controller);
                var listItemClass = (item.Name == activeNavBarItem) ? "active" : "";
                container.InnerHtml += "<li class='" + listItemClass + "'><a href='" + url + "'><i class='" + item.IconClass + "'></i> " + item.Name +"</a></li>";
            }
            
            return MvcHtmlString.Create(container.ToString());
        }

        public static MvcHtmlString WebApplicationName(this HtmlHelper helper)
        {
            return MvcHtmlString.Create(System.Reflection.Assembly.GetAssembly(typeof(Controllers.HomeController)).GetName().Name);
        }
    }
}