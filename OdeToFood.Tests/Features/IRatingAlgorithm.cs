using OdeToFood.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Tests.Features
{
    public interface IRatingAlgorithm
    {
        RatingResult Compute(IList<RestrauntReview> reviews);
    }

    public class SimpleRatingAlgorith : IRatingAlgorithm
    {
        public RatingResult Compute(IList<RestrauntReview> reviews)
        {
            var result = new RatingResult();
            result.Rating = (int)reviews.Average(r => r.Rating);
            return result;
        }
    }

    public class WeightedRatingAlgorithm : IRatingAlgorithm
    {
        public RatingResult Compute(IList<RestrauntReview> reviews)
        {
            var result = new RatingResult();
            var counter = 0;
            var total = 0;

            for (int i = 0; i < reviews.Count(); i++)
            {
                if (i < reviews.Count() / 2)
                {
                    counter += 2;
                    total += reviews[i].Rating * 2;
                }
                else
                {
                    counter += 1;
                    total += reviews[i].Rating;
                }
            }
            result.Rating = total / counter;
            return result;
        }
    }
}