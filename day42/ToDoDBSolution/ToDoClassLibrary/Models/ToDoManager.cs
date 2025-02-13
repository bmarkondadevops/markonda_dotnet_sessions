using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClassLibrary.Models
{
    public class ToDoManager
    {
        private List<ToDo> todos = new List<ToDo>();
        private int nextId = 1;

        public void AddToDo(ToDo todo)
        {
            todo.Id = nextId++;
            todos.Add(todo);
        }

        public List<ToDo> GetToDos()
        {
            return todos;
        }

    }
}
