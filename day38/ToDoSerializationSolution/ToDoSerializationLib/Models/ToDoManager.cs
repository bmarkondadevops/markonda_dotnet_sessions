using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ToDoSerializationLib.Models
{
    
    public class ToDoManager
    {
        private List<ToDo> _todos = new List<ToDo>();
        private int _nextId = 1;


        public void AddToDo(ToDo todo)
        {
            todo._id= _nextId++;
            _todos.Add(todo);
        }

        public List<ToDo> GetToDos()
        {
            return _todos;
        }
    }
}
