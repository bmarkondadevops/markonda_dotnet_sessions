using System;
using System.Reflection;
using DisplayClassInformation.Models;

namespace DisplayClassInformation
{
    internal class Program
    {
        static void Main()
        {
            DoReflection(typeof(Account));
        }

        private static void DoReflection(Type type)
        {
            Console.WriteLine($"Reflection for {type.Name}:");

            // Display Constructors
            Console.WriteLine("Constructors:");
            foreach (ConstructorInfo constructor in type.GetConstructors())
            {
                Console.WriteLine($"  {constructor}");
            }

            // Display Methods
            Console.WriteLine("Methods:");
            foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                Console.WriteLine($"  {method}");
            }

            // Display Properties
            Console.WriteLine("Properties:");
            foreach (PropertyInfo property in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                Console.WriteLine($"  {property}");
            }
        }
    }
}
