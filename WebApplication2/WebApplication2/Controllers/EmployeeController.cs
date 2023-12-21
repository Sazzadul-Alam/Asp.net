using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        RestaurantRepo repo;
        CollectionRequestRepo repos;
        
        public EmployeeController()
        {
            this.repo = new RestaurantRepo();
            this.repos = new CollectionRequestRepo();
        }
        public ActionResult CollectionRequestList()
        {
            var data = repos.GetData();
            return View(data);
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RestaurantList()
        {
            var data = repo.GetAllData();
            return View(data);
        }
        public ActionResult ResturantCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ResturantCreate(RestaurantModel restaurant)
        {
            
            if (ModelState.IsValid)
            {
                var result = repo.ResturantCreate(restaurant);
                return RedirectToAction("RestaurantList");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var data = repo.DeleteData(id);
            return RedirectToAction("RestaurantList");
        }
        public ActionResult Details(int id)
        {
            var data = repo.GetDetails(id);
            return View(data);
        }
        public ActionResult Edit(int id)
        {
            var data = repo.GetDetails(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(int id, RestaurantModel restaurant)
        {

            if (ModelState.IsValid)
            {
                var count = repo.UpdateData(id, restaurant);

                return RedirectToAction("RestaurantList");

            }
            return View();
        }
        public ActionResult Deletes(int id)
        {
            var data = repos.DeleteData(id);
            return RedirectToAction("CollectionRequestList");
        }
    }
}