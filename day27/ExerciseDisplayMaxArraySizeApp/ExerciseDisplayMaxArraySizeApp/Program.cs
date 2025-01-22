
namespace ExerciseDisplayMaxArraySizeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input array
            string[] names = { "markonda", "pathi", "madhavi", "madhavii" };

            // Display Maxlength of all elements
            FindAndDisplayMaxLengthElements(names);
        }

        private static void FindAndDisplayMaxLengthElements(string[] array)
        {
            int maxElementLength = FindMaxLength(array);
            Console.WriteLine("MaxElementLength is::" + maxElementLength);
            int elements = 0;

            foreach (string element in array)
            {
                //Check the all elements == maxlength of array
                if (element.Length == maxElementLength)
                {
                    elements++;
                    Console.WriteLine($"Maxlength names: {element}");
                }

            }
        }

        private static int FindMaxLength(string[] array)
        {
            int maxLength = 0;
            foreach (string element in array)
            {
                if (element.Length > maxLength)
                {
                    maxLength = element.Length;
                }
            }
            return maxLength;
        }


    }
}
