using CV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Education()
        {
            var e1 = new Education()
            {
                Title = "BSc",
                Year = "3rd",
                Ins = "AIUB"

            };
            var e2 = new Education()
            {
                Title = "HSC",
                Year = "2019",
                Ins = "PKFSC"
            };
            var e3 = new Education()
            {
                Title = "SSC",
                Year = "2017",
                Ins = "RMA"
            };
            Education[] eds = new Education[] { e1, e2, e3 };
            return View(eds);
        }
        public ActionResult Projects()
        {
            var p1 = new Projects()
            {
                Name = "Bus Fare Collection System",
                Description = "Software Language: php(Laravel Framework), React js, API Database: MySql " +
               "We are make bus fare collection system",
                GitHub = "https://github.com/Sazzadul42644/Bus-Fare-Collection-System"
            };
            var p2 = new Projects()
            {
                Name = "Bus Fare Collection System",
                Description = "Software Language: php(Laravel Framework), React js, API Database: MySql " +
               "We are make bus fare collection system",
                GitHub = "https://github.com/Sazzadul42644/Bus-Fare-Collection-System"
            };
            var p3 = new Projects()
            {
                Name = "Bus Fare Collection System",
                Description = "Software Language: php(Laravel Framework), React js, API Database: MySql " +
               "We are make bus fare collection system",
                GitHub = "https://github.com/Sazzadul42644/Bus-Fare-Collection-System"
            };
            Projects[] pds = new Projects[] { p1, p2, p3 };
            return View(pds);
        }
           
        
        public ActionResult Reference()
        {
            var r1 = new Reference()
            {
                Name = "TANVIR AHMED",
                Occupation="Teacher",
                Email = "tanvir.ahmed@aiub.edu",

            };
            var r2 = new Reference()
            {
                Name = "Feroz Alam",
                Occupation = "Teacher",
                Email = "feroz@gmail,com",

            };
            Reference[] references = new Reference[] { r1, r2 };
            return View(references);
        }
    }
}