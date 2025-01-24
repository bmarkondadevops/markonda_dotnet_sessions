namespace CheckStringAlphabetOrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Delcare the string array
            string[] stringArray = { "abc", "markonda", "def", "xyz","devops" };

            //Print the string is alphabetical or not
            foreach (var str in stringArray)
            {
                bool isStringInOrder = IsStringInAlphabeticalOrder(str);
                Console.WriteLine($"String:{str}, In alphabetical order: {isStringInOrder}");
            }
        }

        //Check the string IsAlphabeticalOrder
        static bool IsStringInAlphabeticalOrder(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] > str[i + 1])
                    return false;
            }
            return true;
        }
    }
}
