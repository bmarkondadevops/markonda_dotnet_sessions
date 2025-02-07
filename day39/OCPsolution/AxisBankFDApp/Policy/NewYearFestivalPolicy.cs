using FDCoreLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxisBankFDApp.Policy
{
    internal class NewYearFestivalPolicy : IRatePolicy
    {
        public double CalculateRate()
        {
            //checking company growth this month
            //coutnry growth rate
            return 0.10;
        }
    }
}
