using BootstrapV3Template.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapV3Template.Controllers
{
    public class HomeController : Controller
    {
        [NavigationBar(ActiveNavBarItem = "Home")]
        public ActionResult Index()
        {
            return View();
        }

        [NavigationBar(ActiveNavBarItem = "Styles")]
        public ActionResult Styles()
        {
            return View();
        }

        [NavigationBar(ActiveNavBarItem = "Components")]
        public ActionResult Components()
        {
            return View();
        }


    }
}
