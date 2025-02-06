using System;
using System.Runtime.Serialization.DataContracts;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;
using XMLLibrary;

namespace ConDeserializeXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given file path
            var sr = new StreamReader(@"C:\temp\cust1.xml");
            var xmlString = sr.ReadToEnd();

            //Console.WriteLine(xmlString);

            // Deserialize the XML
            XmlSerializer serializer = new XmlSerializer(typeof(Customer));
            using (StringReader reader = new StringReader(xmlString))
            {
                Customer customer = (Customer)serializer.Deserialize(reader);

                // Output the deserialized values
                Console.WriteLine($"Id: {customer.Id}");
                Console.WriteLine($"Name: {customer.Name}");
               
            }

        }
    }
}
