using AccountCounterApp.Models;

namespace AccountCounterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static prorperty
            Console.ForegroundColor = ConsoleColor.Red;

            var venkat = new Account(101, "Venakat", 2000);
            Console.WriteLine(venkat.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            Console.ResetColor();//staic method


            new Account(102, "Minu", 1000);
            Console.WriteLine(venkat.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            new Account(103, "Akhilesh", 3000);
            Console.WriteLine(venkat.InstanceCounter);
            Console.WriteLine(Account.HeadCount);

            Console.WriteLine(Account.HeadCount);

        }
    }
}
