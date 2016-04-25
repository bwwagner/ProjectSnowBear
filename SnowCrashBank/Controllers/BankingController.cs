using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using SnowCrashBank.Models;
using SnowCrashBank.DAL;
using System.Threading.Tasks;

namespace SnowCrashBank.Controllers
{
    public class BankingController : Controller
    {
        public UserManager<ApplicationUser> UserManager { get; private set; }
        // [Authorize]
        public ActionResult Deposit()
        {
            ViewBag.Message = "Deposit page";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Deposit(depositViewModel model)
        {
            if (ModelState.IsValid)
            {
                ProfileContext DB = new ProfileContext();
                Banking acc = new Banking();
                string name = System.Web.HttpContext.Current.User.Identity.GetUserName();
                foreach (Banking x in DB.BankAccounts)
                {
                    if(x.userName == model.userName)
                    {
                        x.Balance += model.Amount;
                        model.Balance = x.Balance - model.Amount;
                    }
                }
                DB.SaveChanges();
            }
            return View(model);
        }

        //[Authorize]
        public ActionResult Withdraw()
        {
            ViewBag.Message = "Withdraw page";
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Withdraw(depositViewModel model)
        {
            if (ModelState.IsValid)
            {
                ProfileContext DB = new ProfileContext();
                Banking acc = new Banking();
                string name = System.Web.HttpContext.Current.User.Identity.GetUserName();
                foreach (Banking x in DB.BankAccounts)
                {
                    if (x.userName == model.userName)
                    {
                        x.Balance -= model.Amount;
                        model.Balance =x.Balance - model.Amount;
                    }
                }
                DB.SaveChanges();
            }
            return View(model);
        }

        //[Authorize]
        public ActionResult Transfer()
        {
            ViewBag.Message = "Transfer page";
            return View();
        }

       // [Authorize]
        public ActionResult Success()
        {
            ViewBag.Message = "Success page";
            return View();
        }

     }
}