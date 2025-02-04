using OrderOrderItemApp.Models;

namespace OrderOrderItemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create some sample order items
            var item1 = new OrderItem("Pens", 2, 10.99);
            var item2 = new OrderItem("Books", 3, 5.99);

            // Create an order
            var order1 = new Order(1, "John Doe");

            // Add items to the order
            order1.AddOrderItem(item1);
            order1.AddOrderItem(item2);

            // Print details of the order
            order1.PrintDetails();
        }
    }
}
