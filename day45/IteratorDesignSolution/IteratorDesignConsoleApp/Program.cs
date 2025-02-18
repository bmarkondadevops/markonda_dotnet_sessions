using IteratorDesingClassLibrary;

namespace IteratorDesignConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new MyNamesCollection();
            names.Add("markonda");
            names.Add("kannan");
            names.Add("pathi");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
