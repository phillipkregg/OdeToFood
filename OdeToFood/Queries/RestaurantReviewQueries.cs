using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OdeToFood.Models;

namespace OdeToFood.Queries
{
    public static class RestaurantReviewQueries
    {
        public static IEnumerable<RestaurantReview> FindTheLatest(this IList<RestaurantReview> reviews, int numberOfReviews)
        {
            return reviews.OrderByDescending(r => r.Created)
                          .Take(numberOfReviews);
        }

        public static RestaurantReview FindById(this IList<RestaurantReview> reviews, int id)
        {
            return reviews.Single(r => r.ID == id);
        }

        public static RestaurantReview FindTheBest(this IList<RestaurantReview> reviews)
        {
            return reviews.OrderByDescending(r => r.Rating).First();
        }
    }
}