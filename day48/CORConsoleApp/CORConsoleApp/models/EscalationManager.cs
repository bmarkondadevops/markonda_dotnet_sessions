using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORConsoleApp.models
{
    internal class EscalationManager : Handler
    {
        public override void Handle(string request)
        {
            Console.WriteLine("Request escalated to manager.");
        }
    }
}
