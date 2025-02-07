using FDCoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDFCBankFDApp.Policy
{
    internal class Q2RatePolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            return 0.08;
        }
    }
}
