using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using ServicesAndDIApp.Services;

namespace ServicesAndDIApp.Controllers
{
    public class CustomerController:Controller
    {
        private IRRDBlobService _rdrEmailService;
        public CustomerController(IRRDBlobService emailService) { 
         _rdrEmailService = emailService;
        }
        public string Index() {

            _rdrEmailService.Log("admin@rrd", "contoller", "customer registration controller");
            return "<h1>Hello I am Index action of home controller</h1>";
        }
    }
}
