using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("<h1>Hello Index content</h1>","text/html");
        }

        public IActionResult Veggie() {
          
            return File("/images/veggie.jpg", "image/jpg");
        }

        public IActionResult About(string myid="101") {

            return Content($"<h1>Id you passed is  {myid},getting details</h1>","text/html");
        
        }

        public IActionResult Greet(string userName="sachin") { 
        
            return Content($"<h1> Welcome back {userName} !!!</h1>","text/html");
        
        }

        public IActionResult Payment() {

            return Redirect("https://rrd.com");
        
        }

        public IActionResult Random() {

            

            var random = new Random();
            var result = random.Next(1, 10);
            if (result > 5)
                return RedirectToAction("About");

            return RedirectToAction("Greet");
        
        }


    }
}
