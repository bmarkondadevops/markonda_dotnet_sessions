

using System;
using RectangleWithEnumColourApp.Models;


namespace RectangleWithEnumColourApp
{
    internal class Program
    {
        static void Main()
        {
            Rectangle r1 = new Rectangle();
            r1.Width = 5;
            r1.Height = 13;
            r1.Colour = Colours.Green;

            Rectangle r2 = new Rectangle();
            r1.Width = 6;
            r1.Height = 18;
            r1.Colour = Colours.Red;
            
            Rectangle r3 = new Rectangle();
            r1.Width = 8;
            r1.Height = 12;
            r1.Colour = Colours.Yellow;

            Rectangle r4 = new Rectangle();
            r1.Width = 4;
            r1.Height = 30;
            r1.Colour = Colours.Orange;

            Rectangle[] rectangles = new Rectangle[4];
            rectangles[0] = r1;
            rectangles[1] = r2;
            rectangles[2] = r3;
            rectangles[3] = r4;

            Console.WriteLine("Size of rectangle is:" + rectangles.Length);

            PrintDetails(rectangles);
        }

        private static void PrintDetails(Rectangle[] rectangles)
        {
            foreach (Rectangle rectangle in rectangles)
            {
                PrintDetails("manyRectangles", rectangle);
            }
        }

        private static void PrintDetails(string details, Rectangle rectangle)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Printing details of : {details}  foreground colour is {rectangle.Colour}");
            Console.WriteLine($"width {rectangle.Width} , height is {rectangle.Height}, Area is {rectangle.Area} ,Colour is {rectangle.Colour}");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
