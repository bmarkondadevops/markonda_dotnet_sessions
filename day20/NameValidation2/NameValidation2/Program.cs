using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        if (IsValidInput(input))
        {
            Console.WriteLine("Input is valid. You entered: " + input);
        }
        else
        {
            Console.WriteLine("Input is not valid. Please enter only letters (a-z or A-Z).");
        }
    }

    static bool IsValidInput(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }
}