using Microsoft.AspNetCore.Mvc;

namespace LoginMiddlewareExcerciseClassOriented.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Console.WriteLine("Home Controller Initiated");
        }

        public IActionResult Index()
        {
            Console.WriteLine("Home Controller Default Index Method");
            return View();
        }
    }
}
