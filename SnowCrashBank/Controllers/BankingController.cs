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

        public ActionResult Deposit()
        {
            ViewBag.Message = "Deposit page";
            return View();
        }

        public ActionResult Withdraw()
        {
            ViewBag.Message = "Withdraw page";
            return View();
        }

        public ActionResult Transfer()
        {
            ViewBag.Message = "Transfer page";
            return View();
        }

    }
}