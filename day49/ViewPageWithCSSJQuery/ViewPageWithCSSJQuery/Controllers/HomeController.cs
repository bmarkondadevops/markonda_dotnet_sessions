using Microsoft.AspNetCore.Mvc;

namespace ViewPageWithCSSJQuery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // Here you would typically validate and authenticate the user.
            // For demonstration purposes, just return a success message.
            return Json(new { Success = true, Message = "Login successful!" });
        }


    }
}
