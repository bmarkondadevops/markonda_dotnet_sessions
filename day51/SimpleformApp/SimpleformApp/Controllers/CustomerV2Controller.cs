using Microsoft.AspNetCore.Mvc;
using SimpleformApp.DTOs;

namespace SimpleformApp.Controllers
{
    public class CustomerV2Controller : Controller
    {
        public IActionResult Register()
        {
            //dto is also known as ViewModel
            var dto = new RegiserationDTO();
            dto.CustomerFirstName = "Testfirstname";
            dto.LastName = "TestLastName";

            return View(dto);
        }

        [HttpPost]
        public IActionResult Register(RegiserationDTO dto)
        {
            //dto is also known as ViewModel
          //validation dto object

            return View(dto);
        }
    }
}
