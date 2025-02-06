using UpdatedSRPViolationApp.Models;

namespace UpdatedSRPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Training Invoice", 100, 0.50);
            Console.WriteLine(invoice.GetInvoiceDetails());
        }
    }
}
