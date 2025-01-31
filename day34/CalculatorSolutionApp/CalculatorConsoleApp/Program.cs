using CalculatorCommonLib.Models;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            try
            {
                Console.WriteLine($"The result is  : {calc.CubeEventNo(3)}"); //we can print the output here itself using the cw
                calc.PositiveNumberAddition(5, 5);
            }
            //catch (NotAnEvenNumberException ex)
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //catch (NotAnEvenNumberException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.WriteLine("End of Main");
        }
    }
}

//Note: All child exeptions should be called before calling Exception