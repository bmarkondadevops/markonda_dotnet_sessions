

namespace ArraySortingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create string array
            string[] array = { "orange", "markonda", "banana", "grape" };

            int startIndex = 0; int endIndex = array.Length - 1;

            ArrayElementinReverseOrder(array);

            Console.WriteLine("Array In reverse order ->");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            //Console.WriteLine("Print reverse string same array");
            //for (int i = array.Length - 1; i >= 0; i--)
            //{               
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine("");

            ////Print before sorting
            //Console.WriteLine("Before sorting:");
            //PrintArray(array);

            ////Sort the array elements
            //BubbleSort(array);

            ////Print after softing
            //Console.WriteLine("After sorting:");
            //PrintArray(array);
        }


        private static void ArrayElementinReverseOrder(string[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                // Swap elements
                string temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                // Move towards the center
                left++;
                right--;
            }
        }

        private static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void BubbleSort(string[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (!CompareFirstCharacter(array[j], array[j + 1]))
                    {
                        // Swap elements
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static bool CompareFirstCharacter(string str1, string str2)
        {
            int len = Math.Min(str1.Length, str2.Length);
            for (int i = 0; i < len; i++)
            {
                if (str1[i] < str2[i])
                    return true;
                else if (str1[i] > str2[i])
                    return false;
            }
            return str1.Length < str2.Length;
        }
    }
}
