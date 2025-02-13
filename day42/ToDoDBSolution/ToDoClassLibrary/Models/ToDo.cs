using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClassLibrary.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }

        //public ToDo(int id, string description, string priority)
        //{
        //    Id = id;
        //    Description = description;
        //    Priority = priority;
        //}

        //public override string ToString()
        //{
        //    return $"Id: {Id}, Description: {Description}, Priority: {Priority}";
        //}
    }
}
