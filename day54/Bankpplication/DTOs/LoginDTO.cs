using System.ComponentModel.DataAnnotations;

namespace Bankpplication.DTOs
{
    public class LoginDTO
    {
        public string HeaderTitle { get; set; } = "";       

        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; } = "";

    }
}
