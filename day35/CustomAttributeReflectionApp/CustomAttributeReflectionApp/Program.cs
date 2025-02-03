using CustomAttributeReflectionApp.Models;
using System.Reflection;

namespace CustomAttributeReflectionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(ClassA);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);

            foreach (var method in methods)
            {
                var attribute = method.GetCustomAttribute<NeedsAttentionAttribute>();
                if (attribute != null)
                {
                    Console.WriteLine($"Method {method.Name} needs attention: {attribute.Message}");
                }
            }
        }
    }
}
