using Microsoft.AspNetCore.Mvc;
using LoginWithBootstrapApp.Model;

namespace LoginWithBootstrapApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Here you would typically authenticate the user.
                // For demonstration purposes, we'll just redirect.
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
