using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassMethodsApp2.Models
{
    public abstract class Vehicle
    {
        public string _make;
        public string _model;
        public int _year;

        // Constructor
        public Vehicle(string make, string model, int year)
        {
            this._make = make;
            this._model = model;
            this._year = year;
        }

        // Abstract method
        public abstract void StartEngine();

        // Non-abstract method
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }        

     }
}
