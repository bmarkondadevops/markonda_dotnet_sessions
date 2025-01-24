using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethodsApp2.Models
{
    internal class MotorCycle:Vehicle
    {
        public int _engineCapacity;

        public int EngineCapacity
        {
            get { return _engineCapacity; } 
            set { _engineCapacity = value; }
        }

        // Constructor
        public MotorCycle(string make, string model, int year, int engineCapacity): base(make, model, year)
        {
            this._engineCapacity = engineCapacity;
        }

        // Implementing the abstract method
        public override void StartEngine()
        {
            Console.WriteLine("The motorcycle engine is starting...");
        }

        // Additional method specific to Motorcycle
        public void KickStart()
        {
            Console.WriteLine("Kicking the motorcycle to start...");
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Engine Capacity: {EngineCapacity}");
        }

    }
}
