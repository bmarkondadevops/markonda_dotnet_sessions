using System;
using ConstructorInheritanceApp.Models;

namespace ConstructorInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //CaseStudy1();

                 //CaseStudy2();
                CaseStudy3();
            }

        private static void CaseStudy3()
        {
            var c1 = new ChildV2(30, "Koenig");
            Console.WriteLine(c1.Age);
            Console.WriteLine(c1.Name);
        }

        private static void CaseStudy2()
        {
            var c1 = new ChildV2();
            var c2 = new ChildV2();
            Console.WriteLine(c1.Age);
            Console.WriteLine(c2.Age);
        }

        private static void CaseStudy1()
        {
            new ChildV1();
        }
    }
}