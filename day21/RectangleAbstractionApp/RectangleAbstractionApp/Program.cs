using System;
using RectangleAbstractionApp.Models;

class RectangleTest {

    static void Main() {
        Rectangle rectangle1;//small expects a rectangel object
        rectangle1 = new Rectangle();
        rectangle1.height = 5;
        rectangle1.width = 10;
        Console.WriteLine($"small width is {rectangle1.width} , height is {rectangle1.height} , area is {rectangle1.CalculateArea()}");

        Rectangle rectangel2 = new Rectangle();
        rectangel2.height = 50;
        rectangel2.width = 100;
        Console.WriteLine($"big width is {rectangel2.width} , height is {rectangel2.height} , area is {rectangel2.CalculateArea()}");
    }
}
