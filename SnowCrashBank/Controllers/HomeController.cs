﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SnowCrashBank.Controllers
{
    public class HomeController : Controller
    {
          // Home Page
        public ActionResult Index()
        {
            ViewBag.Message = "Home Page";
            return View();  // /Home/Index.cshtml
        }

        public ActionResult About()
        {
            ViewBag.Message = "C346 Spring 2016 Semester Project";

            return View();  // /Home/About.cshtml
          }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page";

            return View();  // /Home/Contact.cshtml
          }

     }
}
