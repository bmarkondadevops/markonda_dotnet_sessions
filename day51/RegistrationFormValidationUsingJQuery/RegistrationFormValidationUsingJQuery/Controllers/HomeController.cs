using Microsoft.AspNetCore.Mvc;
using RegistrationFormValidationUsingJQuery.Services;

namespace RegistrationFormValidationUsingJQuery.Controllers
{
    public class HomeController : Controller
    {
        private AuthenticationLogin _authService = new AuthenticationLogin();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            if (username == null || password == null)
            {
                ViewBag.Message = "Registration Failed..All fields required";  //server side validation
                return View();
            }
            if (_authService.IsValid(username, password))
            {
                ViewBag.SuccessMessage = "Login successful!";
                return View();
            }
          
                ViewBag.ErrorMessage = "Invalid UserName or Password...Pls try again";
                return View();
        }
    }

}
