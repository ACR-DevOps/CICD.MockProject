using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.App.CommonLib;

namespace App.Main.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.GreetingMessage = Greeting.ComposeGreetingMsg("This is message coming from Web.App.CommonLib!");
            ViewBag.WebServiceUrlToGetServerName = ConfigurationManager.AppSettings["WebServiceUrlToGetServerName"];
            ViewBag.WebServiceUrlToGetServerTime = ConfigurationManager.AppSettings["WebServiceUrlToGetServerTime"];
            return View();
        }
    }
}