using Microsoft.AspNetCore.Mvc;

namespace MasterApplication.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
