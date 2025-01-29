using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovableInterfaceApp.Model
{
    internal class Bike : Vehicle
    {
        public Bike(string brand, string chasisNo) : base(brand, chasisNo)
        {

        }

        public override void Move()
        {
            Console.WriteLine($"Bike {Brand} is moving..");
        }
    }
}
