using System.Collections;
using CollectionsApp.Models;

namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var basket = new ArrayList();

            basket.Add(new OrderItem(1, "Paste", 2, 25));
            basket.Add(new OrderItem(2, "Pencils", 5, 15));
            basket.Add(new OrderItem(3, "Rice", 1, 1000));
            basket.Add(new OrderItem(4, "Oil", 5, 750));

            // basket.Add("markonda"); //We can add any type of object, but
            //Print the details
            PrintDetails(basket);
        }

        private static void PrintDetails(ArrayList basket)
        {

            double totalAmount = 0;

            foreach (var item in basket)
            {
                OrderItem listItem = (OrderItem)item; //unboxing from Arraylist to orderitem
                //Console.WriteLine(item.Id); //This will get Error because we have to unboxing
                Console.WriteLine($"{listItem.Id}. | Name of Product::{listItem.Name} | No. of Quantity::{listItem.Quantity} | Price per Quantity ::Rs.{listItem.Price} || LineItemCost::{listItem.LineItemCost} ");
                totalAmount += listItem.LineItemCost;

            }
        }
    }
}
