using System;

namespace SumOfOddAndEvenIndexAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize an array 
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Initialize variables to store sums
            int sumEvenIndex = 0;
            int sumOddIndex = 0;

            // Iterate through the array
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    sumEvenIndex += numbers[i];
                }
                else 
                {
                    sumOddIndex += numbers[i];
                }
            }            
            Console.WriteLine("Sum of elements at even indexes: " + sumEvenIndex);
            Console.WriteLine("Sum of elements at odd indexes: " + sumOddIndex);
        }
    }
}

