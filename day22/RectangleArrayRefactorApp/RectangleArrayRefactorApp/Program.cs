using System;
using RectangleArrayRefactorApp.Models;



namespace RectangleArrayRefactorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle[] rectangles = new Rectangle[]
           {
            new Rectangle(3, 4, Color.Red),
            new Rectangle(5, 6, Color.Blue),
            new Rectangle(2, 3, Color.Green),
            new Rectangle(7, 8, Color.Red),
            new Rectangle(1, 2, Color.Blue)
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
