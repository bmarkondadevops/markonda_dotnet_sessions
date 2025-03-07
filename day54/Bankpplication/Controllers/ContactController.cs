using Microsoft.AspNetCore.Mvc;

namespace BankingApplication.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
