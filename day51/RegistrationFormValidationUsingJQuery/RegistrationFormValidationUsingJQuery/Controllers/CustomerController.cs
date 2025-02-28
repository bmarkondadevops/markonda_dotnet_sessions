using Microsoft.AspNetCore.Mvc;
using RegistrationFormValidationUsingJQuery.Services;

namespace RegistrationFormValidationUsingJQuery.Controllers
{
    public class CustomerController : Controller
    {
       
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string firstName, string lastName)
        {

            if (firstName == null || lastName == null)
            {
                ViewBag.Message = "Registration Failed..All fields required";  //server side validation
            }

            else
            {
                ViewBag.Message = $"Hi {firstName} {lastName}!.. Registration Sucessfull, Soon we will get back to you";
            }
            return View();
        }
    }

}