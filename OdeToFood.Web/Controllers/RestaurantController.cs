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
            return View();
        }

        public ActionResult GetRestaurants()
        {
            return View(repo.GetAll());
        }
    }
}