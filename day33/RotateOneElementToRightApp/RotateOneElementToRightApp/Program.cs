

namespace RotateOneElementToRightApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 40, 30, 10, 20 };
            Console.WriteLine("Original Array:");
            PrintArray(array);

            RotateArray(array);

            Console.WriteLine("After Rotated Array Elements:");
            PrintArray(array);
        }

        private static void RotateArray(int[] array)
        {
            if (array.Length == 0) return; 

            int firstElement = array[0];

            // Shift all elements to the left
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            // Place the first element at the end
            array[array.Length - 1] = firstElement;

        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
