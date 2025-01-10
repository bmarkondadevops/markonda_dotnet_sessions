using System.Security.Cryptography.X509Certificates;
using RectangleArrayApp.Models;

namespace RectangleArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangles = new Rectangle[]
        {
            new Rectangle(3.0f, 4.0f, Color.Red),
            new Rectangle(5.0f, 6.0f, Color.Blue),
            new Rectangle(2.0f, 3.0f, Color.Green),
            new Rectangle(7.0f, 8.0f, Color.Red),
            new Rectangle(1.0f, 2.0f, Color.Blue)
        };

            // Initialize variables to hold largest and smallest rectangles
            Rectangle largestRectangle = rectangles[0];
            Rectangle smallestRectangle = rectangles[0];

            // Iterate through the array to find largest and smallest rectangles based on area
            foreach (var rectangle in rectangles)
            {
                if (rectangle.CalculateArea() > largestRectangle.CalculateArea())
                    largestRectangle = rectangle;


                if (rectangle.CalculateArea() < smallestRectangle.CalculateArea())
                    smallestRectangle = rectangle;
            }

            
            // Display results
            Console.WriteLine("Rectangles:");

            foreach (var rect in rectangles)
            Console.WriteLine(rect.ToString());

            Console.WriteLine("\nLargest Rectangle:");
            Console.WriteLine(largestRectangle.ToString());

            Console.WriteLine("\nSmallest Rectangle:");
            Console.WriteLine(smallestRectangle.ToString());

        }
    }
}
