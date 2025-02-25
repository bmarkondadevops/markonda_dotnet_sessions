using Microsoft.AspNetCore.Mvc;

namespace SampleViewPageMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
