using System.ComponentModel.DataAnnotations;

namespace LoginValidationAttributesApp.DTOs
{
    public class LoginDto
    {
        //DataAnnonations
        [Required(ErrorMessage ="Server says username is requried")]
        [StringLength(5,ErrorMessage ="server says Maximum lenght is only 5 ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Server says password is requried")]
        public string UserPassword { get; set; }
    }
}
