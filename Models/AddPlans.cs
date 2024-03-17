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
        [StringLength(11, MinimumLength = 9)]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? DietPlan { get; set; }
        [Required]
        public string? WorkoutPlan { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

    }
}
