using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ToDoSerializationLib.Models
{
    public class ToDo
    {
        public int _id { get; set; }
        public string _description { get; set; }
        public string _priority { get; set; }

        // Default constructor for deserialization
        public ToDo() { }
        public ToDo(int id, string description, string priority)
        {
           this._id = id;
           this._description = description;
           this._priority = priority;
        }

        public override string ToString()
        {
            return $"Id: {_id}, Description: {_description}, Priority: {_priority}";
        }
    }
}
