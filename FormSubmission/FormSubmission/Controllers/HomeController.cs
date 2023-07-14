using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Name = Request["Username"];
            ViewBag.Name = Request["Password"];
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            //ViewBag.Name = form["Username"];
            ViewBag.Name = Username;
            ViewBag.Password = Password;
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Models.SignUp u)
        {

            var test = u.Dob.Date.ToString("yyyy-MM-dd");
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            return View(u);
        }
    }
}