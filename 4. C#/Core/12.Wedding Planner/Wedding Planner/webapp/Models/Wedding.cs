using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models {
    public class Wedding {
        [Key]
        public int WeddingId { get; set; }

        public string WedderOne { get; set; }

        public string WedderTwo { get; set; }

        public DateTime Date { get; set; }

        public string Address { get; set; }

        public int? UserId { get; set; }
        public User Poster { get; set; }

        public List<RSVP> Guests { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
} 