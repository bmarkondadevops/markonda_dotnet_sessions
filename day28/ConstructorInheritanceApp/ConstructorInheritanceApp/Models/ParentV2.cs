using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Models
{
    internal class ParentV2
    {
        private int _age;

        //No default constructor
        public ParentV2(int age)
        {
            _age = age;
            Console.WriteLine("ParentV2 created");
        }

        public int Age
        {
            get { return _age; }
        }
    }
}
