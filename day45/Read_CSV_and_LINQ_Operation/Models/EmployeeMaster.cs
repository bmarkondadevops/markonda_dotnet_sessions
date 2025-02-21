using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_CSV_and_GroupingOperation.Models
{
    internal class EmployeeMaster
    {
       public HashSet<Employee> ReadFromCSVFile(string filePath)
        {
            FileStream fileStream=new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStream);
            var uniqueEmployee = new HashSet<Employee>();
            string headerLine=sr.ReadLine();
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                { 
                    break; 
                } 
                var employeeLinearray = line.Split(",");
                var tempEmpNo = employeeLinearray[0].Replace("'", "");
                int empNo=int.Parse(tempEmpNo);
                var empName = employeeLinearray[1].Replace("'", "");
                var empJob= employeeLinearray[2].Replace("'", "");
                var empMGRid= employeeLinearray[3].Replace("'", "");
                var empDOJ= employeeLinearray[4].Replace("'", "");
                var empSAL= employeeLinearray[5].Replace("'", "");
                var empCOMM = employeeLinearray[6].Replace("'", "");
                var empDEPTNO = employeeLinearray[7].Replace("'", "");

                uniqueEmployee.Add(new Employee { EmpNo = empNo,EmployeeName=empName,EmployeeJob=empJob,EmployeeMGRID=empMGRid,DateofJoining=empDOJ,EmployeeSalary=empSAL,EmployeeCommision=empCOMM,EmployeeDepartmentNo= empDEPTNO });
                
            }
            return uniqueEmployee;
        }
    }
}
