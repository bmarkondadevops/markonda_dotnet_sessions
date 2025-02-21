using Microsoft.AspNetCore.Mvc;

namespace DIWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() {
            Console.WriteLine("Controller created");
        }
        public string SayHello() {
            return "hello";
        }

    }
}
