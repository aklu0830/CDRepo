using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace webapp.Models {
    public class Chef {
        [Key]
        public int ChefId { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        [MinLength(2,ErrorMessage = "Must be atleast 2 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field cannot be empty")]
        [MinLength(2,ErrorMessage = "Must be atleast 2 characters")]
        public string LastName { get; set; }
        [NoPastDateTime]
        public DateTime Dob { get; set; }
        public List<Dish> CreatedDishes { get; set; }
        
    }
    
    public class NoPastDateTime : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (value is DateTime) {
                DateTime checkMe = (DateTime) value;

                if (checkMe > DateTime.Now) {
                    return new ValidationResult("This date doesn't even exist yet");
                } else {
                    return ValidationResult.Success;
                }
            }
            return base.IsValid(value, validationContext);
        }
    }
}