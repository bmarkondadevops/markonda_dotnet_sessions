using System.ComponentModel;
using System.Reflection;
using ManagementCommonLib.Models;
namespace ManagementConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            //Employee
            var employee1 = new Employee("Venkat", "SoftwareEngineer", 50000);
            // Manager
            var teamManager = new Manager("Guru", "TeamLead", 60000, new List<IManagement> {
                                new Employee("Bala", "SoftwareEngineer", 20000.0),
                                 new Employee("Sachin", "Tester", 30000.0),
                                  new Employee("Prem", "SoftwareEngineer", 20000.0) });
            var seniorManager = new Manager("Balaguru", "VP", 100000, new List<IManagement>{
                                        employee1,teamManager });

            // Calculate the cost of the Team
            var teamCost = seniorManager.CalculateCTCforTeam();
            Console.WriteLine($"Team total cost is: {teamCost:C}");
            //seniorManager.ShowDetails();




        }
    }
}
