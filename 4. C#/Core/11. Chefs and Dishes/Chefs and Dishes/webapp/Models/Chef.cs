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
        public DateTime Dob { get; set; }
        public List<Dish> CreatedDishes { get; set; }
        
    }
}