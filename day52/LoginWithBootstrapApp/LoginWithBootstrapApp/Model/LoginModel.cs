using System.ComponentModel.DataAnnotations;

namespace LoginWithBootstrapApp.Model
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Check me out")]
        public bool RememberMe { get; set; }


    }
}
