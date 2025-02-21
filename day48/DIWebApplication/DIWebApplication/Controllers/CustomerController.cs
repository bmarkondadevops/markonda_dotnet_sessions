
using DIWebApplication.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.UI.Services;



namespace DIWebApplication.Controllers
{
    public class CustomerController : Controller
    {
        private IRRDEmailService _irrdEmailService;

        public CustomerController(IRRDEmailService emailService) {
            this._irrdEmailService = emailService;
        }

        public string Index() {
            _irrdEmailService.SendEMailAsync("markonda.reddy@rrd.com", "Testing email", "Custom controll");
            return "<h1>Hello I am Index action of home controller</h1>";
        }
    }
}
