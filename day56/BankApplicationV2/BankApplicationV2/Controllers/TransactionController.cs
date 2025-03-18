using System;

using BankApplicationV2.DTOs;
using BankApplicationV2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace BankApplicationV2.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;

        //via DI
        public TransactionController(ITransactionService transactionService)
        {

            _transactionService = transactionService ?? throw new ArgumentNullException(nameof(transactionService));

        }

       
        public IActionResult PerformTransaction(int accountMasterId)
        {
            var transactionDTO = new AccountTransactionDTO { AccountMasterId = accountMasterId };
            return View(transactionDTO);
        }

        [HttpPost]
        public IActionResult PerformTransaction(AccountTransactionDTO transactionDTO)
        {
             if (ModelState.IsValid)
            {
                if (HttpContext.Session.TryGetValue("LoggedInUserAccountId", out byte[] accountMasterIdBytes) && accountMasterIdBytes != null)
                {
                    int accountMasterId = BitConverter.ToInt32(accountMasterIdBytes, 0);
                    Console.WriteLine("accountMasterId" + accountMasterId);
                    transactionDTO.AccountMasterId = accountMasterId;
                    _transactionService.PerformTransaction(transactionDTO);
                    //_transactionService.UpdateAmount(transactionDTO);
                    return RedirectToAction("TransactionHistory", new { accountMasterId });
                }
                else
                {
                    ModelState.AddModelError("", "Account Master ID not found in session.");
                    return View(transactionDTO);
                }
            }
            return View(transactionDTO);

        }

        [HttpGet]
        public IActionResult TransactionHistory(int accountMasterId)
        {
            var transactions = _transactionService.GetTransactionHistory(accountMasterId);
            return View(transactions);
        }

        /*
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
            dto.AccountTransactions =_customerService.GetTransactions(id);

            return View(dto);
        }       

        */
    }
}
