using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Models {
    public class User {
        [Key] 
        public int UserId { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        [MinLength(2, ErrorMessage = "Must be at least 2 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field cannot be empty")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Activity> ActivitiesCreated { get; set; }

        public List<RSVP> ActivitiesRSVPed { get; set; }

        [NotMapped]
        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}