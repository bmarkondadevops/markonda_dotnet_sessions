using System;
using RectangleWithPropertiesApp.Models;

namespace RectangleWithPropertiesApp
{
    internal class Program
    {
        static void Main()
        {
            Rectangle r1 = new Rectangle();
            r1.Width = 50;
            r1.Height = 20;
            r1.BorderStyle = BorderOptions.Double;

            Rectangle r2 = new Rectangle();
            r2.Width = 10;
            r2.Height = 20;
            r2.BorderStyle = BorderOptions.Single;
            // PrintDetails("r2 rectangel", r2);


            Rectangle r3 = new Rectangle();
            r3.Width = 30;
            r3.Height = 30;
            r3.BorderStyle = BorderOptions.Double;
            //  PrintDetails("r3 rectangel", r3);

            Rectangle[] manyRectangles = new Rectangle[3];
            manyRectangles[0] = r1;
            manyRectangles[1] = r2;
            manyRectangles[2] = r3;

            PrintDetails(manyRectangles);

        }

        private static void PrintDetails(Rectangle[] manyRectangles)
        {
            foreach (Rectangle rectangle in manyRectangles)
            {
                PrintDetails("manyRectangles", rectangle);
            }
        }

        private static void PrintDetails(string details, Rectangle rectangle)
        {


            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("printing details of :" + details + " foreground colro is " + Console.ForegroundColor);
            Console.WriteLine($"width {rectangle.Width} , height is {rectangle.Height}, Area is {rectangle.Area} ,borer is {rectangle.BorderStyle}");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
