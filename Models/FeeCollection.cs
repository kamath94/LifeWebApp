using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace lifedashboard.Models
{
    public class FeeCollection
    {
        [Key]
        public Guid Id { get; set; }

        //[Required]
        //public int MemberId { get; set; }

        [Required]
        public string? Name { get; set; }

        [StringLength(11, MinimumLength =9)]
        [Required(ErrorMessage = "Please enter Phone Number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter Fee Amount")]
        public int? FeeAmount { get; set; }

        [Required(ErrorMessage = "Please enter Date Of Payment")]
        public DateTime? DateOfPayment { get; set; }

        [Required(ErrorMessage = "Please enter Fee Type")]
        public string? FeeType { get; set; }

        public string? Instructors { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }
}