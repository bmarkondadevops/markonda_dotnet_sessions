using Microsoft.AspNetCore.Mvc;

namespace SimpleformApp.Controllers
{
    public class CustomerController : Controller
    {

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string firstName,string lastName)
        {
            if (firstName == null || lastName == null)
            {
                ViewBag.Message = "Registration Failed ,All fields required";
            }
            else {

                ViewBag.Message = $"Hello {firstName} {lastName}  Registration successful ,soon we will get back to you ";
            }
            return View();
        }
    }
}
