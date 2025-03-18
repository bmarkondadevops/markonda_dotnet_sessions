using LoginValidationAttributesApp.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LoginValidationAttributesApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginDto dto)
        {
            if (!ModelState.IsValid) {
                return View();
            }

            //authenctication service

            //  TempData["LoggedInUser"]= dto.UserName;
            HttpContext.Session.SetString("myusername", dto.UserName);
            return RedirectToAction("DisplayAll", "Employee");
        }
    }
}
