using System.ComponentModel.DataAnnotations;

namespace BankApplicationV2.DTOs
{
    public class AccountMasterDeleteDto
    {
        public int Id { get; set; }
        public string HeaderTitle { get; set; } = "";
        public string Message { get; set; } = "";

        [Required]
        public string Name { get; set; } = "";

        [Required]
        public decimal Salary { get; set; }
    }
}
