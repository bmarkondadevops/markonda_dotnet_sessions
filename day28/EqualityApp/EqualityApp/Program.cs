using System;
using EqualityApp.Models;

namespace EqualityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            CaseSTudy2();
        }

        private static void CaseSTudy2()
        {

            var mark1 = new Employee(1, "markonda", 1000);
            var mark2 = new Employee(1, "markonda", 3000);

            Console.WriteLine(mark1 == mark2);//Referential equality

            var mark3 = mark1;
            Console.WriteLine(mark3 == mark1);

            //value based equality
            Console.WriteLine(mark1.Equals(mark2));


        }

        private static void CaseStudy1()
        {
            var emp = new Employee(1, "markonda", 1000);
            Console.WriteLine(emp);
            Console.WriteLine(emp.ToString());

            Console.WriteLine(emp.GetType()); ;
        }
    }
}