using OdeToFood.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class RestaurantController : Controller
    {
        Restaurant_Repo repo = null;

        public RestaurantController()
        {
            repo = new Restaurant_Repo();
        }

        // GET: Restaurant
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = repo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RESTAURANT rest)
        {
            repo.CreateRestaurant(rest);
    
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            repo.DeleteResturant(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = repo.GetById(id); 
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(RESTAURANT rest)
        {
            repo.EditRestaurant(rest);
            return RedirectToAction("Index");
        }


    }
}