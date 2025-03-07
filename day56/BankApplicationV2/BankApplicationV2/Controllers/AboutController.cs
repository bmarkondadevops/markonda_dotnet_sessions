using Microsoft.AspNetCore.Mvc;

namespace BankApplicationV2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
