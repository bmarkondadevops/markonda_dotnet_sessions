using Microsoft.AspNetCore.Mvc;

namespace BankingApplication.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
