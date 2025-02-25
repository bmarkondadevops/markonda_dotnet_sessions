using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternMenuHierarchyApp.Models
{
    public class FileReader : IMenuReader
    {
        public List<MenuItem> ReadMenu(string filePath)
        {
            var menuItems = new List<MenuItem>();

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        string line;
                        bool isHeader = true;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (isHeader)
                            {
                                isHeader = false;
                                continue; // Skip the header
                            }

                            var columns = line.Split(',');

                            if (columns.Length != 3) continue; // Skip malformed rows

                            int id = int.Parse(columns[0]);
                            int? parentId = string.IsNullOrEmpty(columns[1]) ? (int?)null : int.Parse(columns[1]);
                            string menuName = columns[2];

                            menuItems.Add(new MenuItem(id, parentId, menuName));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }

            return menuItems;
        }
    }
}
