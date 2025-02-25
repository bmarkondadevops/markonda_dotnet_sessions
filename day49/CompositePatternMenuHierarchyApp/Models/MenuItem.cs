using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternMenuHierarchyApp.Models
{
    public class MenuItem : IMenuComponent
    {
        public int ID { get; set; }
        public int? ParentID { get; set; }
        public string MenuName { get; set; }

        public MenuItem(int id, int? parentId, string menuName)
        {
            ID = id;
            ParentID = parentId;
            MenuName = menuName;
        }

        public void Display(int indentLevel)
        {
            string indent = new string('-', indentLevel);
            Console.WriteLine($"{indent}{MenuName}");
        }
    }
}
