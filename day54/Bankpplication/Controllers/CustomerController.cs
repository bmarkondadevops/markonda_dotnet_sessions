using Bankpplication.Domain;
using Bankpplication.DTOs;
using Bankpplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bankpplication.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        //via DI
        public CustomerController(ICustomerService customerService)
        {

            _customerService = customerService;
        }
        public IActionResult DisplayAll()
        {
            var dto = new AccountMasterDisplayAllDto();
            dto.Count = _customerService.HeadCount();
            dto.HeaderTitle = "Displaying all Customer Information";
            dto.AccountMaster = _customerService.Get().ToList();

            return View(dto);
        }


        public IActionResult Add()
        {
            var dto = new AccountMasterAddDto();
            dto.HeaderTitle = "Customer Add form";

            return View(dto);
        }

        [HttpPost]
        public IActionResult Add(AccountMasterAddDto dto)
        {
            Console.WriteLine("Enter AccountMasterAddDto postmethod");
            if (ModelState.IsValid)
            {
                var am = new AccountMaster();
                am.Id = _customerService.HeadCount() + 1;
                am.Name = dto.Name;
                am.Balance = dto.Balance;
                _customerService.Add(am);                
                return RedirectToAction("DisplayAll");

            }
            return View(dto);
        }
        
        public IActionResult Edit(int id)
        {
            Console.WriteLine("Enter get edit method");
            var dto = new AccountMasterEditDto();
            dto.HeaderTitle = "Account Master edit form";

            var emp = _customerService.GetById(id);
            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Balance = emp.Balance;
            //dto.Email = emp.Email;
            return View(dto);

        }

        [HttpPost]
        public IActionResult Edit(AccountMasterEditDto dto)
        {
            if (ModelState.IsValid)
            {
                var emp = new AccountMaster();
                emp.Id = dto.Id;
                emp.Name = dto.Name;
                emp.Balance = dto.Balance;
               _customerService.Update(emp);
                return RedirectToAction("DisplayAll");

            }

            return View(dto);

        }

        public IActionResult Remove(int id)
        {

            if (ModelState.IsValid)
            {
                var dto = new AccountMasterDeleteDto();
                _customerService.Remove(id);

                return RedirectToAction("DisplayAll");
            }
            return View();
        } 

    }
}
