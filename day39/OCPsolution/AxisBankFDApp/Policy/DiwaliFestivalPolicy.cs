using FDCoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankFDApp.Policy
{
    internal class DiwaliFestivalPolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            //complext aglo
            return 0.09;
        }
    }
}
