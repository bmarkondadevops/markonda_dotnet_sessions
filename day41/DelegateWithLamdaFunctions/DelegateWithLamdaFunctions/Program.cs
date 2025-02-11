namespace DelegateWithLamdaFunctions
{
    // Define the delegate
    public delegate void DMathOper(int a, int b);
    internal class Program
    {
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
            // Create instances of the delegate and attach methods to it
            DMathOper mathOperation = Add;
            mathOperation += Subtract;
            mathOperation += Multiply;

            // Use lambda expression for modulus operation
            DMathOper modulusOperation = (x, y) =>
            {
                if (y != 0)
                    Console.WriteLine($"Modulus: {x} % {y} = {x % y}");
                else
                    Console.WriteLine("Error: Division by zero is not allowed.");
            };

            // Attach lambda expression to the multicast delegate
            mathOperation += modulusOperation;

            // Invoke the multicast delegate
            mathOperation(10, 2);
        }
    }
}
