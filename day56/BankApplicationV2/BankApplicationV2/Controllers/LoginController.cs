using System;
using BankApplicationV2.Domain;
using BankApplicationV2.DTOs;
using BankApplicationV2.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankApplicationV2.Controllers
{
    public class LoginController : Controller
    {

        private readonly ICustomerService _customerService;

        //via DI
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
               var am=new LoginDTO(); 
                
               
                return RedirectToAction("DisplayAll", "Customer");

            }
            return View(dto);
        }

        public IActionResult Success()
        {    

            return View();
        }
    }
}