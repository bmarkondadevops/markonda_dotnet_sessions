using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace TaxCalcCommonLib.HighLevel
{
    public class TaxCalculator
    {
        private IErrorLogger _logType;

        public TaxCalculator(IErrorLogger logType)
        { 
          _logType = logType;
        }

        public int CalculateTax(int income, int rate) {

            int result = -1;

            try
            {

                result = income / rate;
            } 
            catch(Exception ex) {
               _logType.Log(ex);
            
            }
            return result;
        
        }

    }
}
