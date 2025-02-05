using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderOrderItemApp.Models
{
    public class Order
    {
        public int _orderId { get; set; }
        public string _customerName { get; set; }
        public List<OrderItem> Items { get;  set; }

        public Order(int orderId, string customerName)
        {
            _orderId = orderId;
            _customerName = customerName;
            Items = new List<OrderItem>();
        }

        public void AddOrderItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Order ID: {_orderId}");
            Console.WriteLine($"Customer Name: {_customerName}");

            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }

            // Calculate total cost
            decimal totalCost = (decimal)Items.Sum(i => i._quantity * i._price);           

            Console.WriteLine($"Total Cost: {totalCost}");

            Console.WriteLine(); 
        }
    }
}
