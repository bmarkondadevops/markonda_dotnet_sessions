using System;
using AbstractClassMethodApp.Models;

namespace AbstractClassMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of child classes
            Circle circle = new Circle(3.0);
            Rectangle rectangle = new Rectangle(5.0, 6.0);

            // Calling the abstract method through polymorphism
            Console.WriteLine($"Area of Circle: {circle.Area()}");
            Console.WriteLine($"Area of Rectangle: {rectangle.Area()}");

            // Calling the non-abstract method from the base class
            circle.DisplayShape();
            rectangle.DisplayShape();


        }
    }
}
