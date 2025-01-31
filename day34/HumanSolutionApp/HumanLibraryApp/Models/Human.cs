using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanLibraryApp.Models
{
    public class Human : IHuman
    {
        private string _name;
        private int _age;
        private string _gender;
        private double _height;
        private double _weight;

        public Human(string name, int age, string gender, double height, double weight)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _height = height;
            _weight = weight;

        }

        public string Name { get { return _name; } }

        public int Age { get { return _age; } }

        public string Gender { get { return _gender; } }

        public double Height { get { return _height; } }

        public double Weight { get { return _weight; } }

        public double CalculateBMI()
        {
            return _weight / (_height * _height);
        }

        public void Eat()
        {
            // Increase weight by 10%
            _weight *= 1.10;
            Console.WriteLine($"After eating, {_name}'s weight is now {_weight:F2} kg.");
        }

        public string GetBodyStructure()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5)
                return "Lean";
            else if (bmi < 25)
                return "Slim";
            else if (bmi < 30)
                return "Fat";
            else
                return "Obese";
        }

        public void Workout()
        {
            //Decrease weight by 5 % and increase height by 2 %
            _weight *= 0.95;
            _height *= 1.02;
            Console.WriteLine($"After working out, {_name}'s weight is now {_weight:F2} kg and height is now {_height:F2} m.");
        }
    }
}
