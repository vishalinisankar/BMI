using BMIWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMIWeb.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BMICalculatorResult()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BMICalculatorResult(FormCollection fc,string fna,string lna)
        {
            int height = Convert.ToInt32(fc["txtHeight"]);
            int weight = Convert.ToInt32(fc["txtWeight"]);
            int age = Convert.ToInt32(fc["txtAge"]);
            string type = fc["ddlHeight"];

            return RedirectToAction("Report", new { h = height, w = weight, a = age, t = type , f=fna , l=lna});
        }

        public ActionResult Report(int h, int w, int a, string t,string f,string l)
        {
            ViewData["height"] = "" + h;
            ViewData["weight"] = "" + w;
            ViewData["age"] = "" + a;
            ViewData["type"] = "" + t;
            ViewData["fname"] = "" + f;
            ViewData["lname"] = "" + l;
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserProfile(FormCollection fc)
        {
           
            string fn = fc["name"];
            string ln = fc["lname"];
            return RedirectToAction("BMICalculatorResult",new { fna=fn,lna=ln});
        }
        public ActionResult Normal()
        {
            return View();
        }
        public ActionResult Underweight()
        {
            return View();
        }
        public ActionResult Overweight()
        {
            return View();
        }
        public ActionResult Obese()
        {
            return View();
        }
        public ActionResult Plan1()
        {
            return View();
        }
        public ActionResult Plan2()
        {
            return View();
        }
        public ActionResult Plan3()
        {
            return View();
        }
        public ActionResult Plan4()
        {
            return View();
        }
    }
}