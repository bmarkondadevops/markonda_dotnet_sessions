using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedSRPViolationApp.Models
{
    public class Invoice
    {

        public int Id { get; private set; }
        public string Description { get; private set; }
        public double Cost { get; private set; }
        public double DiscountPercent { get; private set; }

        public Invoice(int id, string description, double cost, double discount)
        {
            Id = id;
            Description = description;
            Cost = cost;
            DiscountPercent = discount;
        }

        // Properties for calculated values
        public double Tax => Cost * 0.10;
        public double Discount => Cost * DiscountPercent;
        public double FinalCost => Cost + Tax - Discount;

        // Method to get invoice details as a string
        public string GetInvoiceDetails()
        {
            return $"Id: {Id}\nDescription: {Description}\nCost: {Cost}\nTax Amount: {Tax}\nDiscount Amount: {Discount}\nFinal Cost: {FinalCost}";
        }
    }
}
