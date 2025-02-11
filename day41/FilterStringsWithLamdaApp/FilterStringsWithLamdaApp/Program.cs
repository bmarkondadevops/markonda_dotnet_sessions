namespace FilterStringsWithLamdaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Markonda", "pathi", "Rama", "Anil", "Madhavi","madhu" };

            Console.WriteLine("Original List:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Use LINQ to filter out names starting with 'M' or 'm'
            var filteredNamesWithLINQ = names.Where(name => name.StartsWith("M", StringComparison.OrdinalIgnoreCase));


            Console.WriteLine("\nNames starting with 'M' or 'm' (LINQ):");
            foreach (var name in filteredNamesWithLINQ)
            {
                Console.WriteLine(name);
            }

            // Use a for loop to filter out names starting with 'M' or 'm'
            Console.WriteLine("\nNames starting with 'M' or 'm' with for loop");
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].StartsWith("M", StringComparison.OrdinalIgnoreCase) || names[i].StartsWith("m", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(names[i]);
                }
            }

            // Use a foreach loop to filter out names starting with 'M' or 'm'
            Console.WriteLine("\nNames starting with 'M' or 'm' ");
            foreach (var name in names)
            {
                if (name.StartsWith("M", StringComparison.OrdinalIgnoreCase) || name.StartsWith("m", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
