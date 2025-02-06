using CustomerCommonLib;
using System.Text.Json;

namespace DeserializaitonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(@"C:\temp\cust1.json");
            var jsonString=sr.ReadToEnd();

            Console.WriteLine(jsonString);

           var customer= JsonSerializer.Deserialize<Customer>(jsonString);

            Console.WriteLine("dserialized customer :"+customer.Name);
            Console.WriteLine("found address "+customer.Addresses.Count);
        }
    }
}
