using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    
    public class OdeToFoodDB : DbContext
    {
        public OdeToFoodDB() : base("name=DefaultConnection")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestrauntReview> Reviews { get; set; }
    }
}
