using System;
using AbstractClassMethodsApp2.Models;

namespace AbstractClassMethodsApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of child classes
            Car car = new Car("Toyota", "Corolla", 2020, 4);
            MotorCycle motorcycle = new MotorCycle("Honda", "Glammer", 2019, 125);

            // Calling car methods on instances
            car.DisplayDetails();
            car.StartEngine();
            car.OpenTrunk();

            Console.WriteLine();

            // Calling MotorCycle methods on instances
            motorcycle.DisplayDetails();
            motorcycle.StartEngine();
            motorcycle.KickStart();

        }
    }
}
