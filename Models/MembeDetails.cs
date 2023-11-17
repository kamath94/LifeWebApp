using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace lifedashboard.Models
{
    public class MembeDetails
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public DateTime? Dob { get; set; }


        [Required]
        public string? FatherName { get; set; }

        [Required]
        public string? FullAddress { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 9)]
        public string? Phone { get; set; }

        [Required]

        public string? Email { get; set; }

        public string? EmergencyNumber { get; set; }

        [Required]
        public string? Relation { get; set; }

        [Required]
        public DateTime? JoiningDate { get; set; }

       
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }

        [Required]
        public string? Bloodgrp { get; set; }

        public string? Height { get; set; }

        public string? Weight { get; set; }

        [Required]
        public string? Timing { get; set; }

        public string? Qualification { get; set; }

        public string? Job { get; set; }

        public int IsActive { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }


    }
}