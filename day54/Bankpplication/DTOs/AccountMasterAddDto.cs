using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
using Bankpplication.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Bankpplication.DTOs
{
    public class AccountMasterAddDto
    {

        public string HeaderTitle { get; set; } = "";
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage ="Username is required")]
        public string Name { get; set; }
        [Required]
        public decimal Balance { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Invalid Email Format")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; } = "";



       

    }
}
