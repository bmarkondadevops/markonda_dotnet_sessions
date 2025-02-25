using ListOfCustomerApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace ListOfCustomerApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var listOfCustomers = GetCustomers();
            return View(listOfCustomers);
        }

        private List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            var customer1 = new Customer
            {
                Id = 1,
                Name = "Markonda",
                Addresses = new List<Address>
                {
                    new Address { Street = "Velachery", City = "Chennai", State = "Tamil Nadu", ZipCode = "600001" },
                    new Address { Street = "KR puram", City = "Bangalore", State = "Karnataka", ZipCode = "560001" }
                }
            };

            var customer2 = new Customer
            {
                Id = 2,
                Name = "Preethi",
                Addresses = new List<Address>
                {
                    new Address { Street = "SR Nagar", City = "Hyderabad", State = "Telangana", ZipCode = "700001" }
                }
            };

            customers.Add(customer1);
            customers.Add(customer2);

            return customers;
        }

    }
}
