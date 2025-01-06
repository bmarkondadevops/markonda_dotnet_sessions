using System;
using System.Net.Http.Headers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to functions");
        PrintName("Markonda", 5);

        bool result = CheckEvenNum(4);

        PrintTodayDate();

        string[] emps = GetAllMemberInTeam();
        foreach (string e in emps)
        {
            Console.WriteLine(e);
        }


        PrintNameWithRecurse("devops",5);
       

    }

    private static void PrintNameWithRecurse(string str, int count)
    {

        if (count == 0)
            return;

        // Print the name
        Console.WriteLine(str);

        // Recursive call with decremented count
        PrintName(str, count - 1);

    }

    static string[] GetAllMemberInTeam()
    {
        //string[] folks = new 
        string[] folks = {
            "markonda",
            "pathi",
            "ramana",
            "kannan"

        };
        return folks;
    }

    static void PrintTodayDate()
    {
        Console.WriteLine(DateTime.Now.ToString("HH:mm"));
    }

    static void PrintName(string userName, int iterations)
    {
        for (int iteration = 1; iteration <= iterations; iteration++)
        {
            Console.WriteLine($"Hello {userName} and {iteration}");
        }
    }


    static bool CheckEvenNum(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Given number is even");
            return true;
        }
        return false;
    }

}




