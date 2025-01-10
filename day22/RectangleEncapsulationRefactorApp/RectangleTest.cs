using RectangelEncapsulationREfacotred.Models;
using System;
using System.Security.Principal;

namespace RectangelEncapsulationREfacotred
{
    internal class RectangleTest
    {
        static void Main(string[] args)
        {
           
            Rectangle firstRectangle = new Rectangle();
            Console.WriteLine("hascode of first " + firstRectangle.GetHashCode());
            firstRectangle.SetWidth(10);
            firstRectangle.SetHeight(20);
           
            PrintInfo("first",firstRectangle);
         
            Rectangle secondRectangle = new Rectangle();
            Console.WriteLine("hascode of second " + secondRectangle.GetHashCode());

            secondRectangle.SetWidth(50);
            secondRectangle.SetHeight(70);
           
            PrintInfo("second ",secondRectangle);


            Rectangle third = secondRectangle;

            third.SetWidth(1);
            third.SetHeight(1);
            PrintInfo("third",third);
            PrintInfo("second",secondRectangle);    
            
         




        }

        static void PrintInfo(string info,Rectangle anyRectangle)//expects an object of  REctangle
        {
            Console.WriteLine("displaying info of "+info);
            Console.WriteLine($"Width: {anyRectangle.GetWidth()}");
            Console.WriteLine($"Height: {anyRectangle.GetHeight()}");
            Console.WriteLine($"Area: {anyRectangle.CalculateArea()}");
            Console.WriteLine($"hashcode is {anyRectangle.GetHashCode()}");
            Console.WriteLine();
        
        }
    }
}
