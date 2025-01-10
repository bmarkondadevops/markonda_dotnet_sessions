namespace RectagleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            rectangle1.CanYouSetWidth(100);
            Console.WriteLine($"widht is {rectangle1.CanYouGetWidth()}");


            rectangle1.CanYouSetHeight(-10);
            Console.WriteLine($"height is {rectangle1.CanYouGetHeight()}");
            Console.WriteLine("Area is " + rectangle1.CalculateArea());

        }
    }
}
                                                                                                                                                                                                                                                                  