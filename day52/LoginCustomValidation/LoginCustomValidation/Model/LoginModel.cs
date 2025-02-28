using System.ComponentModel.DataAnnotations;

namespace LoginCustomValidation.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username must be between 3 and 50 characters", MinimumLength = 3)]
        //[UsernameAvailable(ErrorMessage = "Username is already taken.")]
        [CustomValidationAttributes]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password must be between 6 and 100 characters", MinimumLength = 6)]
        [StrongPassword(ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one digit and one special character.")]
        public string Password { get; set; }
    }
}
