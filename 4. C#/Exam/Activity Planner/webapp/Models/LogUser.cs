using System.ComponentModel.DataAnnotations;

namespace webapp.Models {
    public class LogUser {
        [Required(ErrorMessage = "Email field cannot be empty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password field cannot be empty")]
        public string Password { get; set; }
        
    }
}