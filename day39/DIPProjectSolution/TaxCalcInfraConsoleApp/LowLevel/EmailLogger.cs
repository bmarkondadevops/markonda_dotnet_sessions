using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalcCommonLib.HighLevel;

namespace DIPConsoleViolationApp.LowLevel
{
    internal class EmailLogger : IErrorLogger
    {

        public void Log(Exception ex) { 
           Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(ex.StackTrace);
            Console.WriteLine("Email is send to admin@rrd.com");

            Console.ResetColor();
        }
    }
}
