using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OdeToFood.Models;

namespace OdeToFood.Queries
{
    public static class RestaurantReviewQueries
    {
        public static IEnumerable<Review> FindTheLatest(this IQueryable<Review> reviews, int numberOfReviews)
        {
            return reviews.OrderByDescending(r => r.Created)
                          .Take(numberOfReviews).ToList();
        }

        public static Review FindById(this IQueryable<Review> reviews, int id)
        {
            return reviews.Single(r => r.ID == id);
        }

        //public static RestaurantReview FindTheBest(this IQueryable<RestaurantReview> reviews)
        //{
        //    return reviews.OrderByDescending(r => r.Rating).First();
        //}
    }
}