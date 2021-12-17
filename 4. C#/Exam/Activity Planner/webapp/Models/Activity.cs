using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models {
    public class Activity {
        [Key]
        public int ActivityId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        [NoBeforeDateTime]
        public DateTime Date { get; set; }
        [Required]
        public int Duration { get; set; }
        
        public string DurationType { get; set; }

        public string Description { get; set; }
        [Required]
        public int UserId { get; set; }
        public User Poster { get; set; }

        public List<RSVP> Guests { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
    
    public class NoBeforeDateTime : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (value is DateTime) {
                DateTime checkMe = (DateTime) value;

                if (checkMe < DateTime.Now) {
                    return new ValidationResult("This date has already passed");
                } else {
                    return ValidationResult.Success;
                }
            }
            return base.IsValid(value, validationContext);
        }
    }
} 