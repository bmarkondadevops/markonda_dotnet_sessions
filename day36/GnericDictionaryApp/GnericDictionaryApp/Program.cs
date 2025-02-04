
using GnericDictionaryApp.Model;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GnericDictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // CaseStudy1();

            //CaseStudy2();


            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            var map = new Dictionary<Customer, Customer>();

            var c1 = new Customer { Id=1, Name="Sachin"};
            var c2 = new Customer { Id = 2, Name = "Sachin" };
            var c3 = new Customer { Id = 3, Name = "Deepa" };

            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());

            map.Add(c1, c1);
            map.Add(c2, c2);
            map.Add(c3, c3);

            Console.WriteLine(map.Count);
        }

        private static void CaseStudy2()
        {
            //grouping, occurances

            string[] locations = { "chennai","mumbai","delhi" ,"kerala","kerala", "chennai", "chennai" };

            var map = new Dictionary<string,int>();

            foreach(string location in locations)
            {
                if (!map.ContainsKey(location))
                    map.Add(location, 1); //add
              
                else
                    map[location] = map[location]+1; //update

            }

            foreach (string key in map.Keys)
            {
                Console.Write(key + ":");
                Console.WriteLine(map[key]);
            }


        }

        private static void CaseStudy1()
        {
           var map = new Dictionary<string,string>();
            map.Add("MH", "Maharashtra");
            map.Add("KL", "Kerala");
            map.Add("TN", "TamilNadu");
            map.Add("DL", "Delhi");
            //map.Add("DL", "Delhi"); //already exists

            Console.WriteLine(map["TN"].ToUpper());
            map["TN"] = "Tamil ==> Nadu";

          

            if (map.ContainsKey("KL")) {
                map["KL"] = "New Kerala";
                Console.WriteLine("The map has the key KL ");
            }


            foreach (string key in map.Keys)
            {
                Console.Write(key + ":");
                Console.WriteLine(map[key]);
            }

        }
    }
}
