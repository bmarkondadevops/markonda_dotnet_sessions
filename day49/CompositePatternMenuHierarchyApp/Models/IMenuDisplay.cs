using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternMenuHierarchyApp.Models
{
    public interface IMenuDisplay
    {
        void DisplayMenu(List<MenuItem> menuItems);
    }
}
