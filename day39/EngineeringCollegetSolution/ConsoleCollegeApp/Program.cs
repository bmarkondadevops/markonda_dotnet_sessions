using CollegeLibraryApp.Models;

namespace ConsoleCollegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create multiple student instance
            var students = new Dictionary<int, Student>() {
                {1, new Student(101,"Chennai",new DateTime(2001,1,1),"CSE") },
                {2, new Student(201,"Chennai",new DateTime(1999,10,10),"EEE") },
                {3, new Student(301,"Bangalore",new DateTime(2005,5,6),"CSE") },
                {4, new Student(401,"Hyderabad",new DateTime(2005,5,6),"Civil") }
            };

            // Display student details
            Console.WriteLine("Students:");
            PrintStudents(students);


            // Create multiple professor instances and store in a dictionary
            var professors = new Dictionary<int, Professor>
        {
            {1, new Professor(1, "Pathi", new DateTime(1970, 1, 1), 50000.0, 10000.0, 5000.0)},
            {2, new Professor(2, "Dev", new DateTime(1975, 6, 15), 60000.0, 12000.0, 6000.0)},
            {3, new Professor(3, "Sudharsan", new DateTime(1980, 9, 20), 70000.0, 15000.0, 7000.0)},
            {4, new Professor(3, "Nagababu", new DateTime(1980, 9, 20), 70000.0, 15000.0, 7000.0)}
        };


            // Display professor  details
            Console.WriteLine("\nProfessors:");
            PrintProfessors(professors);

        }

        private static void PrintProfessors(Dictionary<int, Professor> professors)
        {
            foreach (var professor in professors) { 
                //Console.WriteLine(professor.ToString());
                Console.WriteLine($"Professor ID: {professor.Key} - {professor.Value}");
            }
           
        }

        private static void PrintStudents(Dictionary<int, Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Student ID: {student.Key} - {student.Value}");
            }
        }
    }
}
