using Microsoft.AspNetCore.Mvc;
using MVCRepositoryApp.Data;
using MVCRepositoryApp.Models;
using MVCRepositoryApp.Repository;
using System.Diagnostics;

namespace MVCRepositoryApp.Controllers
{
    public class HomeController : Controller
    {
        
        private IOrganizationRepository _organizationRepository;
        public HomeController( IOrganizationRepository organizationRepository)
        {
           
            _organizationRepository = organizationRepository;

           
        }

        public IActionResult Index()
        {

            ViewBag.Count = _organizationRepository.Count() ;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
