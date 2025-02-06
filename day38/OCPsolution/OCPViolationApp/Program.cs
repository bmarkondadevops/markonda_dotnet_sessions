using OCPViolationApp.Models;

namespace OCPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var fd1 = new FixedDeposit(101,"Markonda",100000,10,FestivalType.DIWALI);
            Console.WriteLine(fd1.SimpleInterest);

            var fd2 = new FixedDeposit(102, "Minu", 50000, 10, FestivalType.NEW_YEAR);
            Console.WriteLine(fd2.SimpleInterest);
        }
    }
}
