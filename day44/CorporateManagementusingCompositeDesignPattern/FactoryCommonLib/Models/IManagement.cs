using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementCommonLib.Models
{
    public interface IManagement
    {
        string Name { get; set; }
        string Desigination { get; set; }

        double CalculateCTCforTeam();

        //void ShowDetails();

    }
}
