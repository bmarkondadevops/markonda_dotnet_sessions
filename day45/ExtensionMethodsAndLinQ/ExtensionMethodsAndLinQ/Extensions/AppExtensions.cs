using ExtensionMethodsAndLinQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsAndLinQ.Extensions
{
    internal static class AppExtensions
    {
        public static string HelloRRD(this string input) {

            return $"Hello {input} , RRD welcomes you !!,how do you do";
        }

        public static void PrintAccountDetails(this Account input) {

            Console.WriteLine("Printing deails of account");
            Console.WriteLine(input.Name);
        }
    }
}
