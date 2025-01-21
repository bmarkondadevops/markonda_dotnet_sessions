using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticApplication.Models
{
    internal class MyStaticClass
    {

        public static int MyStaticField = 10;

        static MyStaticClass()
        {
            Console.WriteLine("Static constructor called.");
        }

        public static void MyStaticMethod()
        {
            Console.WriteLine("Static method called.");
        }

        public void MyInstanceMethod()
        {
            Console.WriteLine("Instance method called.");
        }

    }
}
