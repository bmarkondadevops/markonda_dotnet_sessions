using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BankApplicationV2.Domain;

namespace BankApplicationV2.DTOs
{
    public class LoginDTO
    {

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public string HeaderTitle { get; set; }

    }
}
