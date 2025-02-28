using Microsoft.AspNetCore.Mvc;

namespace MasterApplication.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
