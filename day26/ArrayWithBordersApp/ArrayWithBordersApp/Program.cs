namespace ArrayWithBordersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "markonda", "pathi", "ramya","markonda" };
            string[] outputArray = AddStars(inputArray);

            foreach (var item in outputArray)
            {
                Console.WriteLine("*"+item+"*");
            }
        }

        static string[] AddStars(string[] inputArray)
        {
            // Create a new array with two more elements than the input array
            string[] result = new string[inputArray.Length + 2];

            // Add "****" at the beginning
            result[0] = "****";

            // Copy elements from input array to result array
            Array.Copy(inputArray, 0, result, 1, inputArray.Length);

            // Add "****" at the end
            result[result.Length - 1] = "****";

            return result;
        }
    }
}

