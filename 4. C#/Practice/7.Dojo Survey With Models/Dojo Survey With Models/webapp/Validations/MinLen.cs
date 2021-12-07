using System.ComponentModel.DataAnnotations;

namespace webapp.Validations {
    public class MinLen : ValidationAttribute {

        

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if (((string) value).Length < 2)
                return new ValidationResult(validationContext.DisplayName + " value cannot be less than 3 characters");
            return ValidationResult.Success;
        }
        
    }
}