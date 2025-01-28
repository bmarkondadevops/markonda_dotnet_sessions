using System.Reflection.Metadata.Ecma335;

namespace MaxAdjacentElementsApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Initialize an array 
            int[] numbers = { 1, 5, 3, 9, 7, 2, 8, 17 };

            // Differences between adjacent elements and find maximum difference
            int maxDifference = FindMaxAdjacentNumber(numbers);             
            Console.WriteLine("Maximum adjacent difference: " + maxDifference);

            //Find the max number in an Array
            int maxNumber=FindMaxNumberInArray(numbers);

            // Product of maxNumber and adjacent number
            Console.WriteLine($"Product max and adjacent :{maxDifference * maxNumber} ");
        }

        private static int  FindMaxNumberInArray(int[] numbers)
        {
            int maxNumber = 0;
            for (int i = 1; i < numbers.Length; i++) { 

                if(numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }            
            }
            return maxNumber;      
           
        }

        private static int FindMaxAdjacentNumber(int[] numbers)
        {
            int maxDifference = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                // Initialize variable to store maximum difference
                
                int difference = Math.Abs(numbers[i] - numbers[i - 1]);
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                }
            }
            return maxDifference;
        }       
    }
}

