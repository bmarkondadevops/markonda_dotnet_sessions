using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesingClassLibrary 
{
    public class MyNamesCollection: IIterable <string>
    {
        private List<string> names = new List<string>();

        public void Add(string name)
        {
            names.Add(name);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new MyNamesEnumerator(names);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
