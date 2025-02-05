using CustomerGroupByLocationApp.Models;

namespace CustomerGroupByLocationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create customers
            var customers = new List<Customer>
        {
            new Customer("Markonda", "Chennai"),
            new Customer("Preethi", "Chennai"),
            new Customer("Bhanu", "Hyderabad"),
            new Customer("Preem", "New York"),
            new Customer("David", "Chicago"),
            new Customer("Jaggu", "Los Angeles")
        };

            // Group the customers by their location
            var groupedCustomers = GroupCustomersByLocation(customers);

            // Print out the grouped results
            foreach (var pair in groupedCustomers)
            {
                Console.WriteLine($"Location: {pair.Key}");
                foreach (var customer in pair.Value)
                {
                    Console.WriteLine(customer.ToString());
                }
                Console.WriteLine();
            }
        }

        public static Dictionary<string, List<Customer>> GroupCustomersByLocation(List<Customer> customers)
        {
            //-------------------------------------------------------------
            // Use LINQ to group customers by their location
            //var groupedCustomers = customers.GroupBy(c => c._location)
            //                              .ToDictionary(g => g.Key, g => g.ToList());
            //-------------------------------------------------------------

            var groupedCustomers = new Dictionary<string, List<Customer>>();

            foreach (var customer in customers)
            {
                if (!groupedCustomers.ContainsKey(customer._location))
                {
                    // If the location is not already in the dictionary, add it with an empty list.
                    groupedCustomers[customer._location] = new List<Customer>();
                }

                // Add the customer to the list of customers for their location.
                groupedCustomers[customer._location].Add(customer);
            }

            return groupedCustomers;
        }
    }
}
