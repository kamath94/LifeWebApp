using System.ComponentModel.DataAnnotations;

namespace lifedashboard.Models
{
    public class PresentLog
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please enter Attendance Date")]
        public DateTime? AttendDate { get; set; }
        public string? Month { get; set;}
        public DateTime? CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set;}

    }
}
