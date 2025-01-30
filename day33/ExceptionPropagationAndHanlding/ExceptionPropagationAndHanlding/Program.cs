using System.Drawing;

namespace ExceptionPropagationAndHanlding
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Inside Main");

            try
            {
                F1();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error message is :" + ex.Message);
                Console.WriteLine();
                Console.WriteLine("Stack trace is :");

                Console.WriteLine(ex.StackTrace);
                Console.ResetColor();
            }
            Console.WriteLine("End of main");
        }

        static void F1() {
            Console.WriteLine("Inside F1");

            F2();//throw new Exception("Some thing went wrong in F3 ");
            Console.WriteLine("End of F1");

        }
        static void F2()
        {
            Console.WriteLine("Inside F2");

          
             F3();//throw new Exception("Some thing went wrong in F3 ");
           
            

            Console.WriteLine("End of F2");

        }
        static void F3()
        {
            Console.WriteLine("Inside F3");
            throw new Exception("Some thing went wrong in F3 ");

           // Console.WriteLine("End of F3");//Unreachable code

        }



    }
}
