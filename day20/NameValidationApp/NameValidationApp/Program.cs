using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string containing only letters (a-z, A-Z):");

        string input = "";
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            // Check if the key is a letter
            if (char.IsLetter(keyInfo.KeyChar))
            {
                input += keyInfo.KeyChar;
                Console.Write(keyInfo.KeyChar); // Echo the character back to the console
               
            }

            else if (keyInfo.Key == ConsoleKey.Backspace && input.Length > 0)
            {
                input = input.Substring(0, input.Length - 1);
                Console.Write("\b \b"); // Backspace and clear the character
                
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {               
                break; // Exit loop when Enter is pressed
            }
            else
            {
                // Ignore other keys or provide feedback for invalid input
                Console.Beep(); // Beep to indicate invalid input
                Console.WriteLine("Invalid input.Please provide valid input characters[a..zA..Z]");
            }


        }        
        
        Console.WriteLine("\n Valid input: " + input);

    }
}