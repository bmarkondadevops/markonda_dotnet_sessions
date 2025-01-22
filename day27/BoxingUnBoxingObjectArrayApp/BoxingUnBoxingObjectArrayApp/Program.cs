namespace BoxingUnBoxingObjectArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object array
            object[] objArray = { 10, 20, 30, 40, 50 };

            // Find the sum and average of all values in the array
            double sum = 0;
            for (int i = 0; i < objArray.Length; i++)
            {
                // Unboxing: Convert object to int
                sum += (int)objArray[i];
            }

            double average = (double)sum / objArray.Length;

            // Display results
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Sum of all Object values is: {sum}");
            Console.WriteLine($"Average of all value: {average}");
            Console.WriteLine("--------------------------------");
        }
    }
}
