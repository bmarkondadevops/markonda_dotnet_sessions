using System.ComponentModel.Design;
using HumanLibraryApp.Models;

namespace HumanConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create instance for Human class
            IHuman ihuman = new Human("Markonda", 30, "Male", 1.75, 70);

            //Calling methods
            ihuman.Eat();

            ihuman.Workout();

            ihuman.CalculateBMI();

            ihuman.GetBodyStructure();             

        }

    }
}

