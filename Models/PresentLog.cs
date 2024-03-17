using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace lifedashboard.Models
{
    public class PresentLog
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(11, MinimumLength = 9)]

        [Required]
        public string? Phone { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime? AttendDate { get; set; }
        public string? Month { get; set;}
        public DateTime CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set;}

    }
}
