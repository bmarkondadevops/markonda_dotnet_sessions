
using System.ComponentModel;

class Program
{

    static void Main()
    {
        // PrintInfor("Markonda");
        //PrintInfor("@");
        //PrintInfor(100);
        // PrintInfor(100.50d);

        PrintInfo(100);

        PrintInfo(100.56f);


        Console.WriteLine("Sum of two numbers:"+Add(10, 20));
        Console.WriteLine("Sum of two numbers:" + Add(1.0f, 20.56f));        


    }

    static void PrintInfo(int x)
    {
        Console.WriteLine("Overload #1");
        Console.WriteLine(sizeof(int));
        Console.WriteLine($"input value is: {x} and size of integer: {sizeof(int)}");

    }


    static void PrintInfo(float x)
    {
        Console.WriteLine("Overload #1");
        Console.WriteLine(sizeof(int));
        Console.WriteLine($"input value is: {x} and size of integer : {sizeof(float)}");

    }



    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

}
