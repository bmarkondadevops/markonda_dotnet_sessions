using EmployeeCRUDApp.Domain;
using EmployeeCRUDApp.Models;
using Microsoft.Data.SqlClient;

namespace EmployeeCRUDApp.Services
{
    public class EmployeeSqlService : IEmployeeService
    {
           
        private readonly IDbConnectionProvider _connectionProvider;

        public EmployeeSqlService(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public void Add(Employee employee)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO EMPLOYEES (Name, Salary) VALUES (@Name, @Salary)", connection);
                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Salary", employee.Salary);
                command.ExecuteNonQuery();
            }
        }

        public Employee GetById(int id)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT Id, Name, Salary FROM EMPLOYEES WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Employee
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Salary = reader.GetDecimal(2)
                        };
                    }
                }
            }
            return null;
        }

        public int HeadCount()
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT COUNT(*) FROM EMPLOYEES", connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void Remove(int id)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM EMPLOYEES WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                if (command.ExecuteNonQuery() == 0)
                    throw new Exception("Employee was not found");
            }
        }

        public void Update(Employee employee)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE EMPLOYEES SET Name = @Name, Salary = @Salary WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Name", employee.Name);
                command.Parameters.AddWithValue("@Salary", employee.Salary);
                command.Parameters.AddWithValue("@Id", employee.Id);

                if (command.ExecuteNonQuery() == 0)
                    throw new Exception("Employee was not found");
            }
        }

        public IEnumerable<Employee> Get()
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT Id, Name, Salary FROM EMPLOYEES", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return new Employee
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Salary = reader.GetDecimal(2)
                        };
                    }
                }
            }
        }
    }
}
