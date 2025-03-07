using Bankpplication.Domain;
using Bankpplication.DTOs;
using Bankpplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankingApplication.Controllers
{
    public class LoginController : Controller
    {

        private readonly ICustomerService _customerService;

        //via DI
        public LoginController(ICustomerService customerService)
        {

            _customerService = customerService;

        }
        public IActionResult Login()
        {
            var dto = new LoginDTO();
            dto.HeaderTitle = "Please Enter Username and Password to Login";

            return View(dto);
        }

        [HttpPost]
        public IActionResult Login(LoginDTO dto)
        {
            Console.WriteLine("Enter into LoginDTO Login page");
            if (ModelState.IsValid)
            {
                var am = new AccountMaster();
                am.Name = dto.Name;
                am.Password = dto.Password;
                _customerService.Login(am);
                return RedirectToAction("DisplayAll", "Customer");

            }
            return View(dto);
        }

        //public IActionResult DisplayAllByUser()
        //{
        //    var dto = new AccountMasterDisplayAllDto();
        //    dto.Count = _customerService.HeadCount();
        //    dto.HeaderTitle = "Displaying all Customer Information";
        //    dto.AccountMaster = _customerService.GetAllByUser().ToList();

        //    return View(dto);
        //}
    }
}
