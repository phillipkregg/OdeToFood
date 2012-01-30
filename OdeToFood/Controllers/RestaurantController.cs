using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class RestaurantController : Controller
    {
        //
        // GET: /Restaurant/


        OdeToFoodDB _db = new OdeToFoodDB();

        public ActionResult Index(string state)
        {

            ViewBag.States = _db.Restaurants.Select(r => r.Address.State).Distinct();

            var model = _db.Restaurants
                            .OrderByDescending(r => r.Address.City)
                            .Where(r => r.Address.State == state || (state == null));
                      
            //var model = from r in _db.Restaurants
            //            orderby r.Address.City descending
            //            where r.Address.State == state || state == null
            //            select r;
         
            return View(model);
        }


        public ActionResult Details(int id)
        {
            var model = _db.Restaurants.Single(r => r.ID == id);

            return View(model);
        }



    }
}
