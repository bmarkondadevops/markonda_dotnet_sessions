using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIteratorCommonLib.Models
{
    public class Iterator : IAbstractIterator
    {
        private EmployeeCollection Collection;
        private int Current = 0;
        private readonly int Step = 1;

        public Iterator(EmployeeCollection Collection)
        {

            this.Collection = Collection;
        }

        public Employee First()
        {
            Current = 0;
            return Collection.GetEmployee(Current);
        }

        public Employee Next()
        {
            Current += Step;
            if (!IsCompleted)
            {
                return Collection.GetEmployee(Current);
            }
            else
            {
                return null;
            }
        }

        public bool IsCompleted
        {
            get { return Current >= Collection.Count; }
        }
    }
}