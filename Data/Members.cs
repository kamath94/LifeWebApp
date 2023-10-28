using Postgrest.Attributes;

namespace lifedashboard.Data
{
    [Table("MemberDetails")]
    public class Members
    {
        [PrimaryKey("id")]
        public int Id { get; set; }
        [Column("Name")]
        public string? Name { get; set; }
        [Column("Age")]
        public int Age { get; set; }
        [Column("Dob")]
        public DateTime? Dob { get; set; }
        [Column("JoiningDate")]
        public DateTime? JoiningDate { get; set; }

        [Column("FatherName")]
        public string? FatherName { get; set; }
        [Column("FullAddress")]
        public string? FullAddress { get; set; }
        [Column("Phone")]
        public string? Phone { get; set; }
        [Column("Email")]
        public string? Email { get; set; }
        [Column("EmergencyNumber")]
        public string? EmergencyNumber { get; set; }
        [Column("Relation")]
        public string? Relation { get; set; }
        [Column("Qualification")]
        public string? Qualification { get; set; }
        [Column("Job")]
        public string? Job { get; set; }
        [Column("Gender")]
        public string? Gender { get; set; }
        [Column("MaritalStatus")]
        public string? MaritalStatus { get; set; }
        [Column("Bloodgrp")]
        public string? Bloodgrp { get; set; }
        [Column("Height")]
        public string? Height { get; set; }
        [Column("Weight")]
        public string? Weight { get; set; }
        [Column("Timing")]
        public string? Timing { get; set; }
        [Column("AttendDate")]
        public string? AttendDate { get; set; }
        [Column("IsActive")]
        public int IsActive { get; set; }
        [Column("FeeAmount")]
        public string? FeeAmount { get; set; }
        [Column("DateOfPayment")]
        public DateTime? DateOfPayment { get; set; }

        List<string> Instructors = new List<string>();
    }
}
