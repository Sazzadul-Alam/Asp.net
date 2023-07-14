using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zerohunger.Models;
using Zerohunger.Repository;

namespace Zerohunger.Controllers
{
    public class UserController : Controller
    {
        UserRepo repo;

        public UserController()
        {
            this.repo = new UserRepo();
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            var data = repo.GetType();
            ViewBag.typeData = data;
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(UserModel user)
        {
            var data = repo.GetType();
            ViewBag.typeData = data;
            if (ModelState.IsValid)
            {
                var result = repo.AddUser(user);
                return RedirectToAction("Login");
            }

            return View();
        }
        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(UserModel user)
        {
            if (ModelState.IsValid)
            {
                var result = repo.LoginUser(user);
                if (result == 1)
                {
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    return RedirectToAction("Index", "Restaurant");
                }

            }
                return View();
        }
    }
}