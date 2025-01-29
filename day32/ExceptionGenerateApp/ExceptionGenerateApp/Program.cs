namespace ExceptionGenerateApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstNo = int.Parse( args[0]); // "10"
            int second = int.Parse( args[1]);  // "5"
            int divResult = firstNo / second;

            Console.WriteLine($"{firstNo} / {second} = {divResult}");

            Console.WriteLine("end of the program!!");

            //Main(args);

        }
    }
}
