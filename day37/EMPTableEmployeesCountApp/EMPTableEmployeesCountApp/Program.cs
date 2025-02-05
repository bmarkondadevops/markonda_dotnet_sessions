
namespace EMPTableEmployeesCountApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Path to your CSV file
            string filePath = "C:\\temp\\emp_duplicate.csv";

            if (File.Exists(filePath))
            {
                var counts = CountEmployeesByRole(filePath);
                DisplayCounts(counts);
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }

        public static Dictionary<string, int> CountEmployeesByRole(string filePath)
        {
            var counts = new Dictionary<string, int>
        {
            {"Total", 0},
            {"clerk", 0},
            {"manager", 0},
            {"salesman", 0},
            {"analyst", 0},
            {"president", 0},

        };

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    // Skip header if any
                    reader.ReadLine();

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        if (fields.Length >= 2) // Assuming role is in second column
                        {
                            string job = fields[2].Trim().Replace("'", "").ToLower();
                            //Console.WriteLine($"{job}");
                            counts["Total"]++;

                            switch (job)
                            {
                                case "clerk":
                                    counts["clerk"]++;
                                    break;
                                case "manager":
                                    counts["manager"]++;
                                    break;
                                case "salesman":
                                    counts["salesman"]++;
                                    break;
                                case "analyst":
                                    counts["analyst"]++;
                                    break;
                                case "president":
                                    counts["president"]++;
                                    break;

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return counts;
        }

        public static void DisplayCounts(Dictionary<string, int> counts)
        {
            Console.WriteLine("Employee Counts:");
            Console.WriteLine($"Total Employees: {counts["Total"]}");
            Console.WriteLine($"Number of Clerks: {counts["clerk"]}");
            Console.WriteLine($"Number of Managers: {counts["manager"]}");
            Console.WriteLine($"Number of Salesmen: {counts["salesman"]}");
            Console.WriteLine($"Number of Analyst: {counts["analyst"]}");
            Console.WriteLine($"Number of President: {counts["president"]}");
        }
    }
}
