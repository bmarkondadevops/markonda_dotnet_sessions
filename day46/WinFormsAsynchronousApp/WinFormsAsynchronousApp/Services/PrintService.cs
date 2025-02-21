using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAsynchronousApp.Services
{
    internal class PrintService
    {
        public void Print()
        {
            while (true)
            {
                Debug.WriteLine($"Current Date and time :{DateTime.Now.ToString("hh:mm:ss")} ");
            }

        }
    }
}
