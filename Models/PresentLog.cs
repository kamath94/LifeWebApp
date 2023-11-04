using System.ComponentModel.DataAnnotations;

namespace lifedashboard.Models
{
    public class PresentLog
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Phone { get; set; }
        [Required]
        public DateTime? AttendDate { get; set; }
        [Required]
        public string? Month { get; set;}

        public DateTime? CreateDate { get; set; }

       public DateTime? LastModifiedDate { get; set;}

    }
}
