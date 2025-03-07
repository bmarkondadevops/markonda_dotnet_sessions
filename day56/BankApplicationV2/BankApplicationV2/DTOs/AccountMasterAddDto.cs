using System.ComponentModel.DataAnnotations;
using BankApplicationV2.Domain;

namespace BankApplicationV2.DTOs
{
    public class AccountMasterAddDto
    {

        public string HeaderTitle { get; set; } = "";
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Balance { get; set; }
       
        public string Email { get; set; }

        public string Password { get; set; }

    }
}
