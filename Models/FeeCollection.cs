using System.ComponentModel.DataAnnotations;

namespace lifedashboard.Models
{
    public class FeeCollection
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int MemberId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? FeeAmount { get; set; }

        [Required]
        public DateTime? DateOfPayment { get; set; }

        [Required]
        public string? FeeType { get; set; }

        public string? Instructors { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}