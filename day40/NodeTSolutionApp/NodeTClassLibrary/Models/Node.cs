using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeTClassLibrary.Models
{
    public class Node<T>
    {
        private T _data;

        public Node<Employee> next { get; set; }

        public Node(T data)
        {
            _data = data;
           
        }

        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }

       
    }

   
}
