using System;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models {
    public class User {
        [Key] public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}