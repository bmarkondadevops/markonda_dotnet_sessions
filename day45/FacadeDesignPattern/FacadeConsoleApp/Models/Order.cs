using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeCommonLib.Models;

namespace FacadeConsoleApp.Models
{
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("We Placed the Orded");
            //Product Details
            Product product = new Product();
            Console.WriteLine(product.GetProductDetails());
            //Payment Details
            Payment payment = new Payment();
            Console.WriteLine(payment.MakePayment());
            //Invoice Details
            Invoice invoice = new Invoice();
            Console.WriteLine(invoice.Sendinvoice());
            Console.WriteLine("Your Order Placed Successfully");
        }
    }
}