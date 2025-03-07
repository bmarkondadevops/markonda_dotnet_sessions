using System.ComponentModel.DataAnnotations;

namespace Bankpplication.DTOs
{
    public class AccountMasterDeleteDto
    {
        public string HeaderTitle { get; set; } = "";
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Balance { get; set; }

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";
    }
}
