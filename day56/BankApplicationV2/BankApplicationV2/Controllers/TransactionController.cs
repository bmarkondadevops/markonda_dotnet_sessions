using System.Linq;
using BankApplicationV2.Domain;
using BankApplicationV2.DTOs;
using BankApplicationV2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace BankApplicationV2.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ICustomerService _customerService;

        //via DI
        public TransactionController(ICustomerService customerService)
        {

            _customerService = customerService;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AccountTransactionDTO dto)
        {

            if (ModelState.IsValid)
            {
                var am = new AccountTransaction();
                am.Id = dto.AccountMasterId;
                am.Name = dto.Name;
                am.Type = dto.TransactionType;
                am.Date = dto.Date.ToString();
                _customerService.CreateTransaction(dto);
                
                return RedirectToAction("DisplayAll", "Customer");

            }
            return View(dto);
        }

        [HttpGet]
        public IActionResult Display(int id)
        {
            var dto = new AccountTransactionAllDTO();
            dto.Count = _customerService.HeadCount() + 1;
            dto.HeaderTitle = "Displaying all Transaction Information";
            // Convert List<AccountTransactionDTO> to List<AccountTransaction>
            dto.AccountTransactions = (System.Collections.Generic.List<AccountTransaction>)_customerService.GetTransactions(id);

            return View(dto);
        }       


    }
}
