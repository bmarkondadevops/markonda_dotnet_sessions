using CompositePatternMenuHierarchyApp.Models;

namespace CompositePatternMenuHierarchyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\MenuHierarchyBuilder.txt";

            // Instantiate the classes with Dependency Injection
            var fileReader = new FileReader();
            var menuDisplay = new MenuDisplay();
            var menuBuilder = new MenuBuilder(fileReader, menuDisplay);

            // Build and display the menu hierarchy
            menuBuilder.BuildAndDisplayMenu(filePath);
        }
    }
}
    


