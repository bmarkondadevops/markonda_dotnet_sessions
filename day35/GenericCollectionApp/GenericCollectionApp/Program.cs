using GenericCollectionApp.Models;
using System;
using System.Collections.Generic;

namespace GenericCollectionApp
{
    internal class Program
    {

        public Program()
        {

            Console.WriteLine("inside program constructor");
        }
        static void Main(string[] args)
        {

            List<OrderItem> basket = new List<OrderItem>();
            basket.Add(new OrderItem { Name = "book", Quanity = 5, UnitPrice = 30, Id = 1 });
            basket.Add(new OrderItem { UnitPrice = 10, Name = "Pen", Quanity = 5, Id = 2 });
            basket.Add(new OrderItem { Name = "Milk", Quanity = 3, UnitPrice = 35, Id = 3 });

            double totalCost = 0;
            foreach (OrderItem item in basket)
            {
                Console.WriteLine(item);
                totalCost += item.LineItemCost;

            }
            Console.WriteLine("Total payment is " + totalCost);
        }


    }
}
