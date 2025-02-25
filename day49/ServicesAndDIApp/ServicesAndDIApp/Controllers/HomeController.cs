using Microsoft.AspNetCore.Mvc;

namespace ServicesAndDIApp.Controllers
{
    public class HomeController:Controller
    {
        public HomeController() {
            Console.WriteLine("controller created");
         
        }

        public string Index() {
            return "Hello rom index action o home controller";
        }

        public string SayHello() {

            return "Hello";
        }
        //display==>dipslay.cshtml
        public ActionResult Display() {

            return View();
        }
    }
}
