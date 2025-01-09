using System;
using System.Drawing;
using CircleApp1.Models;

namespace CircleApp1
{
    internal class Program
    {
        static void Main()
        {
            // Create a new Circle object
            Circle circle = new Circle();
            circle.radius = 5.0f;

            // Calculate and display the area
            float area = circle.CalculateArea();
            Console.WriteLine($"The area of the circle with radius {circle.radius} is {area}");

        }
    }
}
