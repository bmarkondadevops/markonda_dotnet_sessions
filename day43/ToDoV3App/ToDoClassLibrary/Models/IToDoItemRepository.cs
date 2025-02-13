using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClassLibrary.Models
{
    public interface IToDoItemRepository
    {
        void CreateToDoItem(string title, string description);
        void ReadToDoItems();
        void UpdateToDoItem(int id, string title, string description);
        void DeleteToDoItem(int id);
    }
}
