using Microsoft.AspNetCore.Mvc;

namespace LoginFormWithoutDTOApp.Controllers
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
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                ViewBag.Message = "Registration Failed from serverside ,All fields required";
                return View();
            }

            if (firstName.Length < 2 || firstName.Length > 15)
            {
                ViewBag.Message = "First name must be between 2 and 15 characters from serverside.";
                return View();
            }

            if (lastName.Length < 2 || lastName.Length > 10)
            {
                ViewBag.Message = "Last name must be between 2 and 10 characters from serverside.";
                return View();
            }

            // If all validations pass, proceed with registration logic.
            ViewBag.Message = $"Hello {firstName} {lastName}  Registration successful ,soon we will get back to you ";
            return View();
        }












        //[HttpPost]
        //public IActionResult Register(string firstName,string lastName)
        //{
        //    if (firstName == null || lastName == null)
        //    {
        //        ViewBag.Message = "Registration Failed ,All fields required";
        //    }
        //    else {

        //        ViewBag.Message = $"Hello {firstName} {lastName}  Registration successful ,soon we will get back to you ";
        //    }
        //    return View();
        //}
    }
}
