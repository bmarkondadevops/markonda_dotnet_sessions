
using CustomerCommonLib;
using System.Text.Json;

namespace SerializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerializeToJson();
        }

        private static void SerializeToJson()
        {
            //var c1 = new Customer { Id=1,Name="Markonda",
            //    Addresses= new List<Address> { 
            //     new Address { City="Chennai",Country="India" },
            //     new Address { City="Mumbai",Country="India" }
            //    } };


            //var jsonString= JsonSerializer.Serialize(c1);
            //Console.WriteLine(jsonString);
            //var sw = new StreamWriter(@"C:\temp\cust1.json");
            //sw.WriteLine(jsonString);
            //sw.Close();
            //Console.WriteLine("written to file");
        }
    }
}
