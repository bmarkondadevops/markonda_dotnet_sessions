using ControllersAndActions.Model;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Display() {

            var c1 = new Customer { 
             City = "Chennai",
             Id = 1,
             Name= "Venkat",
           
            };
            return View(c1);
        
        }
    }
}
