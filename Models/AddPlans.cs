using System.ComponentModel.DataAnnotations;

namespace lifedashboard.Models
{
    public class AddPlans
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
       
        [Required]
        public string? PhoneNumber { get; set; }

        public string? DietPlan { get; set; }
        public string? WorkoutPlan { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

    }
}
