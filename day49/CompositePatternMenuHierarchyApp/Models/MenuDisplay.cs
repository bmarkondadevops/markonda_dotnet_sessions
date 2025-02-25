using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternMenuHierarchyApp.Models
{
    public class MenuDisplay : IMenuDisplay
    {
        public void DisplayMenu(List<MenuItem> menuItems)
        {
            var rootMenus = menuItems.Where(m => m.ParentID == null).ToList();

            foreach (var rootMenu in rootMenus)
            {
                rootMenu.Display(2);  // Indentation for root level
                DisplaySubMenus(menuItems, rootMenu.ID, 4);  // Indentation for submenus
            }
        }

        private void DisplaySubMenus(List<MenuItem> menuItems, int parentId, int indentLevel)
        {
            var childMenus = menuItems.Where(m => m.ParentID == parentId).ToList();

            foreach (var childMenu in childMenus)
            {
                childMenu.Display(indentLevel);  // Display with indentation
                DisplaySubMenus(menuItems, childMenu.ID, indentLevel + 2);  // Increase indentation for the next level
            }
        }
    }
}
