using DIPConsoleViolationApp.LowLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DIPConsoleViolationApp.HighLevel
{
    internal class TaxCalculator
    {
        private LogType _logType;

        public TaxCalculator(LogType logType)
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
                if (_logType == LogType.EMAIL)
                {

                    var emailLogger = new EmailLogger();
                    emailLogger.Log(ex);
                }
                else if (_logType == LogType.XML) { 
                
                    //xml logger
                }
                else
                {

                    var textLogger = new TextLogger();
                    textLogger.Log(ex);
                }
            
            }
            return result;
        
        }

    }
}
