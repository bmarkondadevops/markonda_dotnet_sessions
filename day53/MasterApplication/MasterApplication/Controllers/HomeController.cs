using Microsoft.AspNetCore.Mvc;

namespace MasterApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
