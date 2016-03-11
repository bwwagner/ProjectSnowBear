using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SnowCrashBank.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "C346 Spring 2016 Semester Project";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }
    }
}