using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace SnowCrashBank.Controllers
{
    public class BankingController : Controller
    {
        [Authorize]
        public ActionResult Deposit()
        {
            ViewBag.Message = "Deposit page";
            return View();
        }

        //[Authorize]
        public ActionResult Withdraw()
        {
            ViewBag.Message = "Withdraw page";
            return View();
        }

        [Authorize]
        public ActionResult Transfer()
        {
            ViewBag.Message = "Transfer page";
            return View();
        }

        [Authorize]
        public ActionResult Success()
        {
            ViewBag.Message = "Success page";
            return View();
        }

     }
}