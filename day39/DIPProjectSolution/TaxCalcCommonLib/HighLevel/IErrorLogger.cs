using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalcCommonLib.HighLevel
{
    public interface IErrorLogger
    {
        void Log(Exception ex);
    }
}
