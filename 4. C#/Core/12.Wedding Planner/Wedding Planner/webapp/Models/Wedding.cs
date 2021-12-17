using System;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models {
    public class Wedding {
        [Key]
        public int WeddingId { get; set; }

        public string WedderOne { get; set; }

        public string WedderTwo { get; set; }
        
        public DateTime Date { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}