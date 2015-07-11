using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    public class RestrauntReview : IValidatableObject
    {
        public int Id { get; set; }

        [Range(1,10)]
        [Required]
        public int Rating { get; set; }

        [Required]
        [StringLength(1024)]
        public string Body { get; set; }

        [Required]
        [Display(Name ="User Name")]
        [DisplayFormat(NullDisplayText ="Annon")]
        public string ReviewerName { get; set; }
        public int RestaurantId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Rating < 2 && ReviewerName.ToLower().StartsWith("Arnido"))
            {
                yield return new ValidationResult("No Trolls Allowed");
            }
        }
    }
}
