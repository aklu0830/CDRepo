using System.ComponentModel.DataAnnotations;
using webapp.Validations;

namespace webapp.Models {
    public class HogwartsStudent {
        [Required]
        [MinLen]
        
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Language { get; set; }
        [MaxLength(20)]
        public string Comments { get; set; }
    }
}