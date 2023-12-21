using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        UserRepo repo;

        public UserController()
        {
            this.repo = new UserRepo();
        }
        // GET: User

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
                    return RedirectToAction("Index", "Restaurant");
                }
                else
                {
                    return RedirectToAction("Index", "Employee");
                }

            }
            return View();
        }
    }
}