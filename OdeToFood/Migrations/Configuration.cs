namespace OdeToFood.Migrations
{
    using OdeToFood.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToFood.Models.OdeToFoodDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToFood.Models.OdeToFoodDB";
        }

        protected override void Seed(OdeToFood.Models.OdeToFoodDB context)
        {
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Baris", City = "Waco", Country = "USA" },
                new Restaurant { Name = "Georges", City = "Waco", Country = "USA" },
                new Restaurant
                {
                    Name = "Viteks BBQ",
                    City = "Waco",
                    Country = "USA",
                    Reviews =
                        new List<RestrauntReview>
                        {
                            new RestrauntReview { Rating = 4, Body = "Good Gutpacks, but just OK BBQ", ReviewerName = "Odinra" }
                        }
                });
        }
    }
}
