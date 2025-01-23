
namespace ShiftCharactersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "computer";
            string output = TransformString(input);
            Console.WriteLine(output); // Output: omputers
        }

        static string TransformString(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
                return input; 

            // Remove the first character
            string newString = input.Substring(1);

            // Get the last character of the new string
            char lastChar = newString[newString.Length - 1];

            // Determine the next letter in the alphabet
            char nextLetter;
            if (lastChar == 'z' || lastChar == 'Z')
                nextLetter = lastChar == 'z' ? 'a' : 'A'; // Wrap around to 'a' or 'A'
            else
                nextLetter = (char)(lastChar + 1);

            // Append the next letter to the end of the new string
            return newString + nextLetter;
        }
    }
}
