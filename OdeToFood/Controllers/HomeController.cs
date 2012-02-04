using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;
using OdeToFood.Queries;
using System.Threading;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {

        OdeToFoodDB _db = new OdeToFoodDB();

        public PartialViewResult LatestReview()
        {
            Thread.Sleep(2000);
            var review = _db.Reviews.FindTheLatest(1).Single();
            return PartialView("_Review", review);


        }

        public ViewResult Index()
        {
            ViewBag.Message = "Welcome to Ode To Food";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Location = "Maryland, USA";

            return View();
        }
    }
}

