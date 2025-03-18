using System;
using System.Linq;
using BankApplicationV2.Domain;
using BankApplicationV2.DTOs;
using BankApplicationV2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop.Infrastructure;

namespace BankApplicationV2.Controllers
{
    public class LoginController : Controller
    {

        private readonly ICustomerService _customerService;

        public LoginController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }


        //via DI

        /*
        public IActionResult Login()
        {
            var dto = new LoginDTO();
            dto.HeaderTitle = "Please Enter Username and Password to Login";
            return View(dto);
        }

        [HttpPost]
        public IActionResult Login(LoginDTO dto)
        {            
            if (ModelState.IsValid)
            {
                var am = new AccountMaster();                           
              
                return RedirectToAction("LoginSuccess","Login");

            }
            return View(dto);
        }

        public IActionResult LoginSuccess()
        {
            var dto=new LoginDTO();
            ViewBag.userName = dto.Name;

            return View();
        }
        */
        [HttpGet]
        public IActionResult Login()
        {
            var dto = new LoginDTO();
            dto.HeaderTitle = "Please Enter Username and Password to Login";
            return View(dto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginDTO model)
        {
            //if (ModelState.IsValid)
            //{
            //    var account = _customerService.AuthenticateUser(model.Email, model.Password);
            //    if (account != null)
            //    {
            //        // Set session or cookie for logged-in user
            //        HttpContext.Session.SetString("LoggedInUserEmail", account.Email);
            //        byte[] accountMasterIdBytes = BitConverter.GetBytes(account.Id);
            //        HttpContext.Session.Set("LoggedInUserAccountId", accountMasterIdBytes); // Store AccountMasterId
            //        return RedirectToAction("LoginSuccess");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "Invalid username or password");
            //    }
            //}
            //return View(model);
            if (ModelState.IsValid)
            {
                var account = _customerService.AuthenticateUser(model.Email, model.Password);
                if (account != null)
                {
                    // Set session or cookie for logged-in user
                    HttpContext.Session.SetString("LoggedInUserEmail", account.Email);
                    byte[] accountMasterIdBytes = BitConverter.GetBytes(account.Id);
                    HttpContext.Session.Set("LoggedInUserAccountId", accountMasterIdBytes); // Store AccountMasterId
                    return RedirectToAction("LoginSuccess");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }
            return View(model);

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("LoggedInUserEmail");
            return RedirectToAction("Login");
        }

        public IActionResult LoginSuccess()
        {
            string email = HttpContext.Session.GetString("LoggedInUserEmail");
            if (email != null)
            {
                var account = _customerService.GetAccountByEmail(email);
                if (account != null)
                {
                    return View(account);
                }
            }
            return RedirectToAction("Login");
        }

        public IActionResult LoginFailure()
        {
            return View();
        }

    }
}