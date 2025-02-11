namespace DelegateDMathOperApp
{
    internal class Program
    {
        // Define the delegate
        public delegate void DMathOper(int a, int b);


        // Methods that match the delegate signature
        public static void Add(int a, int b)
        {
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
        }

        static void Main(string[] args)
        {
            DMathOper mathOperation = Add;
            mathOperation += Subtract;
            mathOperation += Multiply;

            // Invoke the multicast delegate
            mathOperation(10, 2);
        }
    }



}

