using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Serialization;

namespace webappR.Models {
    public class User {
        [Key] 
        public int UserId { get; set; }
        [Required]
        public string Email { get; set; }
        
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2,ErrorMessage = "Last Name must be at least 2 characters")]
        public string LastName { get; set; }
        [Required]
        [MinLength(2,ErrorMessage = "Username must be at least 3 Characters")]
        public string Username { get; set; }
        [Required]
        [MinLength(8,ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords Must Patch")]
        
        public string ConfirmPassword { get; set; }
    }
}