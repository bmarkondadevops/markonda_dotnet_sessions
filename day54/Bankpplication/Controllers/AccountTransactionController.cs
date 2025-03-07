using Bankpplication.DTOs;
using Bankpplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bankpplication.Controllers
{
    public class AccountTransactionController : Controller
    {
        private readonly IAccountTransactionService _accountTransactionService;

        //via DI
        public AccountTransactionController(IAccountTransactionService accountTransactionService)
        {

            _accountTransactionService = accountTransactionService;

        }
        public IActionResult DisplayAll()
        {
            var dto = new AccountTransactionDisplayAllDTO();
            dto.Count = _accountTransactionService.HeadCount();
            dto.HeaderTitle = "Displaying all Customer Information";
           

            return View(dto);
        }
    }
}
