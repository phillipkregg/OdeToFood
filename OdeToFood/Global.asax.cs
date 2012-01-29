using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using OdeToFood.Infrastructure;
using OdeToFood.Models;


namespace OdeToFood
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
           
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Route order is significant!!!
            //  The first route that matches the URL wins

            routes.MapRoute(
                "Cuisine",
                "cuisine/{name}",
                new { controller = "Cuisine", action = "Search", name = UrlParameter.Optional }
            );

            routes.MapRoute(                
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {

            Database.SetInitializer(new OdeToFoodDBInitializer());

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }


    public class OdeToFoodDBInitializer : DropCreateDatabaseIfModelChanges<OdeToFoodDB>
    {
        protected override void Seed(OdeToFoodDB context)
        {
            base.Seed(context);

            context.Restaurants.Add(new Restaurant
            {
                Name = "Marrakesh",
                Address = new Address
                {
                    City = "Washington",
                    State = "D.C.",
                    Country = "USA"
                }
            });

            context.Restaurants.Add(new Restaurant
            {
                Name = "Sabatino's",
                Address = new Address
                {
                    City = "Baltimore",
                    State = "MD",
                    Country = "USA"
                }
            });

            context.Restaurants.Add(new Restaurant
            {
                Name = "The Kings Contrivance",
                Address = new Address
                {
                    City = "Columbia",
                    State = "MD",
                    Country = "USA"
                }
            });

            context.Restaurants.Add(new Restaurant
            {
                Name = "Taco Bell",
                Address = new Address
                {
                    City = "Nashville",
                    State = "TN",
                    Country = "USA"
                }
            });

            context.SaveChanges();
        }

        
    }


}