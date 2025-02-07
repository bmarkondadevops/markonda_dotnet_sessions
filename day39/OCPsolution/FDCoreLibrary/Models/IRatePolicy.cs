using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDCoreLibrary.Models
{
    public interface IRatePolicy
    {
        double CalculateRate();
    }
}
