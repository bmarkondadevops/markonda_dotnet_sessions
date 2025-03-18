using Microsoft.AspNetCore.Mvc;
using TagHelpersAndSessionApp.DTOs;

namespace TagHelpersAndSessionApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginDTO dto)
        {
            return View();
        }


    }
}
