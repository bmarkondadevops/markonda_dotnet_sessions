using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Models
{
    internal class ChildV2 : ParentV2
    {
        private string _name;
        public ChildV2() : base(10) {
            Console.WriteLine("childv2 created");
        }

        public ChildV2(int age, string name) : base(age) {
            _name = name;
            Console.WriteLine("childv2 created");
        }
        public string Name
        {
            get { return _name; }
        }
    }
}
