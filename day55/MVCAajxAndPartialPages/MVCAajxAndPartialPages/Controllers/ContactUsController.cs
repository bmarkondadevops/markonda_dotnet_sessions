using Microsoft.AspNetCore.Mvc;
using MVCAajxAndPartialPages.DTOs;

namespace MasterLayoutApp.Controllers
{
    public class ContactUsController : Controller
    {
        private ILogger<ContactUsController> _logger;
        public ContactUsController(ILogger<ContactUsController> logger) {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetTimeStamp() {

            return PartialView("_TimeStamp",new TimeStampDto { Title="Contacts us Timestampe" });
        
        }

        public IActionResult GetTimeStampBlocking()
        {
            var beforeThead = Thread.CurrentThread.ManagedThreadId;
            _logger.LogWarning("before thread id " + beforeThead);
            Thread.Sleep(5*1000);//db operation or some io operation

            var afterThead = Thread.CurrentThread.ManagedThreadId;

            _logger.LogWarning("after thread id " + afterThead);
            return PartialView("_TimeStamp", new TimeStampDto { Title = "Contacts us Timestampe" });

        }

        public async Task<IActionResult> GetTimeStampNonBlocking()
        {
            var beforeThead = Thread.CurrentThread.ManagedThreadId;
            _logger.LogWarning("before thread id " + beforeThead);
            await  Task.Run(() =>
              {
                  Thread.Sleep(5 * 1000);//db operation or some io operation

              });
            var afterThead = Thread.CurrentThread.ManagedThreadId;

            _logger.LogWarning("after thread id " + afterThead);
            return PartialView("_TimeStamp", new TimeStampDto { Title = "Nonblocking Timestampe" });

        }
    }
}
