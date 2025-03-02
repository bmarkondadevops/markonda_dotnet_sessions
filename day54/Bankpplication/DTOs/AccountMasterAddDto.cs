using System.ComponentModel.DataAnnotations;
using Bankpplication.Domain;

namespace Bankpplication.DTOs
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



        //public int Id { get; set; }
        //public string HeaderTitle { get; set; } = "";
        //public string Message { get; set; } = "";

        //[Required]
        //public string Name { get; set; } = "";

        //[Required]
        //public decimal Salary { get; set; }

    }
}
