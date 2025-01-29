using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp.Model
{
    internal abstract class Vehicle : IMovable
    {
        private string _brand;
        private string _chasisNo;

        public Vehicle(string brand, string chasisNo) { 
          _brand = brand;
          _chasisNo = chasisNo;
        
        }

        public string Brand { get { return _brand; } }
        public string ChasisNo { get { return _chasisNo; }}

        public abstract void Move();
     
    }
}
