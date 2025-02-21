using DIWebApplication.services;
using Microsoft.AspNetCore.Mvc;

namespace DIWebApplication.Controllers
{
    public class MyController : Controller
    {

        private IRRDEmailService _irrdEmailService;
        public MyController(IRRDEmailService emailService)
        {
            this._irrdEmailService = emailService;
        }

        //public string Mark()
        //{
        //    return "Welcome to markonda!!!";
        //}

        public string Index()
        {
            _irrdEmailService.SendEMailAsync("markonda.reddy@rrd.com", "Testing email", "Custom controll");
            return "Welcome to MyController";
        }
    }
}
