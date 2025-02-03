using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeReflectionApp.Models
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class NeedsAttentionAttribute : Attribute
    {
        public string Message { get; set; }

        public NeedsAttentionAttribute(string message = "This method needs attention")
        {
            Message = message;
        }
    }
}
