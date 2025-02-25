using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternMenuHierarchyApp.Models
{
    public class MenuBuilder
    {
        private readonly IMenuReader _menuReader;
        private readonly IMenuDisplay _menuDisplay;

        public MenuBuilder(IMenuReader menuReader, IMenuDisplay menuDisplay)
        {
            _menuReader = menuReader;
            _menuDisplay = menuDisplay;
        }

        public void BuildAndDisplayMenu(string filePath)
        {
            var menuItems = _menuReader.ReadMenu(filePath);
            _menuDisplay.DisplayMenu(menuItems);
        }
    }
}
