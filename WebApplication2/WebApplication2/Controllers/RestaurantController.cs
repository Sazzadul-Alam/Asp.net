using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class RestaurantController : Controller
    {
        RestaurantRepo repo;
        CollectionRequestRepo repos;

        public RestaurantController()
        {
            this.repo = new RestaurantRepo();
            this.repos = new CollectionRequestRepo();
        }
        // GET: Restaurant
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RestaurantList()
        {
            var data = repo.GetAllData();
            return View(data);
        }
        public ActionResult Details(int id)
        {
            var data = repos.GetDetails(id);
            return View(data);
        }
        public ActionResult CollectionRequestList()
        {
            var data = repos.GetData();
            return View(data);
        }
        public ActionResult CollectionRequestCreate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CollectionRequestCreate(CollectionRequestModel collectionRequest)
        {
            if (ModelState.IsValid)
            {
                var result = repos.CollectionRequestCreate(collectionRequest);
                return RedirectToAction("CollectionRequestList");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var data = repos.GetDetails(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(int id, CollectionRequestModel collectionRequest)
        {

            if (ModelState.IsValid)
            {
                var count = repos.UpdateData(id, collectionRequest);

                return RedirectToAction("CollectionRequestList");

            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            var data = repos.DeleteData(id);
            return RedirectToAction("CollectionRequestList");
        }
    }
}