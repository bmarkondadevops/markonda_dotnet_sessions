using AxisBankFDApp.Policy;
using FDCoreLibrary.Models;

namespace AxisBankFDApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var fd1 = new FixedDeposit(101,"abc",10000,10,new DiwaliFestivalPolicy());
            Console.WriteLine(fd1.SimpleInterest);

        }
    }
}
