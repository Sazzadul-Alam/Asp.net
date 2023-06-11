using ITCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITCompany.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
         

            return View();
        }

        public ActionResult Teams()
        {
            var t1 = new Teams()
            {
                Name = "Sazzadul Alam",
                Position = "Web Developer",
                Email = "sazzadul@gmail.com",

            };
            var t2 = new Teams()
            {
                Name = "Feroz Alam",
                Position = "Graphis Deginer",
                Email = "feroz@gmail,com",

            };
            var t3 = new Teams()
            {
                Name = "Akash",
                Position = "Software Enginner",
                Email = "akash@gmail,com",

            };
            var t4 = new Teams()
            {
                Name = "Tahmina Akter",
                Position = "HR",
                Email = "tahmina@gmail,com",

            };
            Teams[] team = new Teams[] { t1, t2,t3,t4 };
            return View(team);

        }
        public ActionResult Contact()
        {


            return View();
        }
    }
}