using System;
using System.IO;

namespace InputDataFromStreamWritterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Giving username and address
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your address: ");
            string address = Console.ReadLine();

            // Define the file path 
            string filePath = "user_data.txt";

            // Write data to the file using FileStream and StreamWriter
            WriteDataToFile(username, address, filePath);

            Console.WriteLine("Data saved successfully to " + filePath);
        }

        static void WriteDataToFile(string username, string address, string filePath)
        {
            try
            {
                // Create a FileStream object
                using (FileStream fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                {
                    // Create a StreamWriter object
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine("Username: " + username);
                        writer.WriteLine("Address: " + address);
                        writer.WriteLine(); 
                    }
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while writing data to the file: " + e.Message);
            }
        }
    }
}
