using StaticApplication.Models;

namespace StaticApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accessing static field and method without creating an instance
            Console.WriteLine(MyStaticClass.MyStaticField);
            MyStaticClass.MyStaticMethod();

            // Creating an instance and accessing instance method
            MyStaticClass myInstance = new MyStaticClass();
            myInstance.MyInstanceMethod();
        }
    }
}
