using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesingClassLibrary
{
    public class MyNamesEnumerator : IEnumerator<string>
    {

        private List<string> names;
        private int position = -1;

        public MyNamesEnumerator(List<string> names)
        {
            this.names = names;
        }

        public string Current
        {
            get { return names[position]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            position++;
            return position < names.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            // No resources to dispose.
        }

    }
}
