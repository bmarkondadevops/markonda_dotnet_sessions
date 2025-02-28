using Microsoft.AspNetCore.Mvc;

namespace LoginWithBootstrapApp.Controllers
{
    public class LoginController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
