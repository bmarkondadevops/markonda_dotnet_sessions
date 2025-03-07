using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BankApplicationV2.Domain;

namespace BankApplicationV2.DTOs
{
    public class LoginDTO
    {

        public int Count { get; set; }   

        public List<AccountMaster> AccountMaster { get; set; }
        public string HeaderTitle { get; set; } = "";


        [StringLength(20, MinimumLength = 3)]
        [Required(ErrorMessage = "Username is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = "";

    }
}
