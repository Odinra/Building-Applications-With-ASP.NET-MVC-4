using System;
using OdeToFood.Models;
using System.Linq;

namespace OdeToFood.Tests.Features
{
    internal class RestaurantRater
    {
        private Restaurant _restaurant;

        public RestaurantRater(Restaurant restaurant)
        {
            this._restaurant = restaurant;
        }

        public RatingResult ComputeResult(IRatingAlgorithm algorithm,
                                            int numberOfReviewsToUse)
        {
            var filteredReviews = _restaurant.Reviews.Take(numberOfReviewsToUse);

            return algorithm.Compute(filteredReviews.ToList());
        }

        //public RatingResult ComputeRating(int numberOfReviews)
        //{
        //    var result = new RatingResult();
        //    result.Rating = (int)_restaurant.Reviews.Average(r => r.Rating);
        //    return result;
        //}

        //public RatingResult ComputeWeightedRating(int numberOfReviews)
        //{
        //    var reviews = _restaurant.Reviews.ToArray();
        //    var result = new RatingResult();
        //    var counter = 0;
        //    var total = 0;

        //    for (int i = 0; i < reviews.Count(); i++)
        //    {
        //        if (i < reviews.Count() / 2)
        //        {
        //            counter += 2;
        //            total += reviews[i].Rating * 2;
        //        }
        //        else
        //        {
        //            counter += 1;
        //            total += reviews[i].Rating;
        //        }
        //    }
        //    result.Rating = total / counter;
        //    return result;
        //}
    }
}