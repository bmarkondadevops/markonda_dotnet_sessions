using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedSRPViolationApp.Models
{
    public class InvoiceCalculator
    {

        private const double TaxRate = 0.10;

        public double CalculateTax(double cost)
        {
            return cost * TaxRate;
        }

        public double CalculateDiscount(double cost, double discountPercent)
        {
            return cost * discountPercent;
        }

        public double CalculateFinalCost(double cost, double tax, double discount)
        {
            return cost + tax - discount;
        }
    }
}
