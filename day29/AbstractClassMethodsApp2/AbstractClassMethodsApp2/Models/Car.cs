using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethodsApp2.Models
{
    internal class Car:Vehicle
    {
        public int _numberOfDoor;        

        public int NumberOfDoor {  
            get { return _numberOfDoor; }
            set { _numberOfDoor = value; }
        }      


        // Constructor
        public Car(string make, string model, int year, int numberOfDoors): base(make, model, year)
        {
            this._numberOfDoor = numberOfDoors;
        }



        // Implementing the abstract method
        public override void StartEngine()
        {
            Console.WriteLine("The car engine is starting...");
        }

        // Additional method specific to Car
        public void OpenTrunk()
        {
            Console.WriteLine("Opening the car trunk...");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, NoOfDoors:{NumberOfDoor}");
        }
    }
}
