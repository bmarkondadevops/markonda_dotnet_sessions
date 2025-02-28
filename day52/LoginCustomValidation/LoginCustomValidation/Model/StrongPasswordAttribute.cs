using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace LoginCustomValidation.Model
{
    public class StrongPasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;
            if (string.IsNullOrEmpty(password))
                return ValidationResult.Success;

            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$%*?&])[A-Za-z\d@$%*?&]{6,}$");
            if (regex.IsMatch(password))
                return ValidationResult.Success;

            return new ValidationResult("Password must contain at least one uppercase letter, one lowercase letter, one digit and one special character.");
        }
    }

}
