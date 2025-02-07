using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPConsoleViolationApp.LowLevel
{
    internal class TextLogger
    {
             public void Log(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("File is created for the logs..");

                Console.ResetColor();
            }
        }
    
}
