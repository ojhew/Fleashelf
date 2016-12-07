using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fleashelf003.Models;

namespace Fleashelf003.Controllers
{
    public class AccountController : Controller
    {


        // GET: Account
        public ActionResult Index()
        {

            using (OurDbContext db = new OurDbContext())
            {
              return View();
            }
        }


        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Register(DbUserAccount acc)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.UserAccount.Add(acc);
                    if (db.SaveChanges() == 1)
                    {
                        Session["Email"] = acc.Email;
                        ViewBag.Message =  acc.Email+" SuccessFully Registered!. An Email was sent to your account.Please verify you email account";
                    }
                }
            }
            return View();
        }
    }
}