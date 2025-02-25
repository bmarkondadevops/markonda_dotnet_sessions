using Microsoft.AspNetCore.Mvc;

namespace ActionRedirectionApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Greet(string userName = "Markonda")
        {

            return Content($"<h1> Welcome back {userName} !!!</h1>", "text/html");

        }

        public IActionResult ImageDisplay() {
            return File("/images/Nivetha1.png", "image/png");
        }


        public IActionResult Redirection()
        {
            // Redirect to a different action or controller
            return RedirectToAction("Display","Customer");
        }
    }
}
