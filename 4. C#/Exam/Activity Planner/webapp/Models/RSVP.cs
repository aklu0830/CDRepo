using System.ComponentModel.DataAnnotations;

namespace webapp.Models {
    public class RSVP {
        [Key]
        public int RSVPId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}