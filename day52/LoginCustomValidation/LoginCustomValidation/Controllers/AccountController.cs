using LoginCustomValidation.Model;
using LoginCustomValidation.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginCustomValidation.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Here you would typically authenticate the user against your database or authentication service.
            // For demonstration purposes, we'll just assume it's valid.
            return RedirectToAction("Index", "Home");
        }
    }
}
