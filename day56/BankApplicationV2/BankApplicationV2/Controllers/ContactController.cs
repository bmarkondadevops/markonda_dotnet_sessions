using Microsoft.AspNetCore.Mvc;

namespace BankApplicationV2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
