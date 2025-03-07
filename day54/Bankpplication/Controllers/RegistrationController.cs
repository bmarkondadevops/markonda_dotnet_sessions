using Bankpplication.Domain;
using Bankpplication.DTOs;
using Bankpplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankingApplication.Controllers
{
    public class RegistrationController : Controller
    {

        private readonly ICustomerService _customerService;

        //via DI
        public RegistrationController(ICustomerService customerService)
        {

            _customerService = customerService;

        }
        public IActionResult Add()
        {
            var dto = new AccountMasterAddDto();
            dto.HeaderTitle = "Please fill the Customer Registration form";
            return View(dto);
        }       

        [HttpPost]        
        public IActionResult Add(AccountMasterAddDto dto)
        {

            if (ModelState.IsValid)
            {
                var am = new AccountMaster();
                am.Id = _customerService.HeadCount() + 1;
                am.Name = dto.Name;
                am.Balance = dto.Balance;
                am.Email = dto.Email;
                am.Password = dto.Password;
                _customerService.Add(am);
                return RedirectToAction("DisplayAll","Customer");

            }
            return View(dto);
        }

    }
}
