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
} 