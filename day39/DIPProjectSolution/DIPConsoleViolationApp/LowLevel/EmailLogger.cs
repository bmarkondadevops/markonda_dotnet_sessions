using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPConsoleViolationApp.LowLevel
{
    internal class EmailLogger
    {

        public void Log(Exception ex) { 
           Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("Email is send to admin@rrd.com");

            Console.ResetColor();
        }
    }
}
