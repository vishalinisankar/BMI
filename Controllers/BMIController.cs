using BMIWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMIWeb.Controllers
{
    public class BMIController : Controller
    {
        // GET: BMI
        public ActionResult Index()
        {
            using (var db = new MyDbContext())
            {
                return View(db.userAccount.ToList());
            }
            //return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User_account account)
        {
            if (ModelState.IsValid)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();

                }
                ModelState.Clear();
                ViewBag.Message = ""+account.FirstName + " " + account.LastName + " successfully registered ";
            }
            return View();
        }
        //login page
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User_account user)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var usr = db.userAccount.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
                if (usr != null)
                {
                    Session["UserID"] = usr.UserId.ToString();
                    Session["UserName"] = usr.Username.ToString();
                   
                    return RedirectToAction("LoggedIn");

                }
                
                else
                {
                    ModelState.AddModelError("", "Username or Password is incorrect.");
                    
                }
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Glossary()
        {
            return View();
        }
    }
}





