using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIteratorCommonLib.Models
{
    public interface IAbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}