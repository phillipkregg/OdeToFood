using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class FoodDb
    {
        static FoodDb()
        {
            _reviews = new List<RestaurantReview>();
            _reviews.Add(new RestaurantReview
            {
                Body = "A fantistic culinary pleasure.",
                Created = DateTime.Now,
                ID = 1,
                Rating = 9,
                Restaurant = new Restaurant
                {
                    Name="Mannequin Pis", 
                    ImageUrl = "http://localhost:55444/Content/images/restaurant.jpg"
                }
            });

            _reviews.Add(new RestaurantReview
            {
                Body = "Only eat here if you must.",
                Created = DateTime.Now,
                ID = 2,
                Rating = 3,
                Restaurant = new Restaurant
                {
                    Name="School Cafeteria",                    
                    ImageUrl = "http://localhost:55444/Content/images/restaurant.jpg"
                }
            });

            _reviews.Add(new RestaurantReview
            {
                Body = "I'm lucky to still be alive.",
                Created = DateTime.Now,
                ID = 3,
                Rating = 3,
                Restaurant = new Restaurant
                {
                    Name="Joe's Deep Fried Bacon Cheesburger Shack",
                    ImageUrl = "http://localhost:55444/Content/images/restaurant.jpg"
                }
            });
        }

        public IList<RestaurantReview> Reviews 
        {
            get { return _reviews; }
        }

        static List<RestaurantReview> _reviews;

    }
}