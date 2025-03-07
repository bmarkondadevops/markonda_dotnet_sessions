using Bankpplication.Domain;
using Bankpplication.Models;
using Bankpplication.Services;

using Microsoft.Data.SqlClient;



namespace Bankpplication.Services
{
    public class CustomerSqlService : ICustomerService
    {
           
        private readonly IDbConnectionProvider _connectionProvider;

        public CustomerSqlService(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public void Add(AccountMaster accountMaster)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO ACCOUNTMASTER (Name, Balance,Email,Password) VALUES (@Name, @Balance,@Email,@Password)", connection);
                command.Parameters.AddWithValue("@Name", accountMaster.Name);
                command.Parameters.AddWithValue("@Balance", accountMaster.Balance);
                command.Parameters.AddWithValue("@Email", accountMaster.Email);
                command.Parameters.AddWithValue("@Password", accountMaster.Password);
                command.ExecuteNonQuery();
            }
        }

        public AccountMaster GetById(int id)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT Id, Name, Balance FROM ACCOUNTMASTER WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new AccountMaster
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Balance = reader.GetDecimal(2)
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
                var command = new SqlCommand("SELECT COUNT(*) FROM ACCOUNTMASTER", connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public void Remove(int id)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM ACCOUNTMASTER WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                if (command.ExecuteNonQuery() == 0)
                    throw new Exception("Customer was not found");
            }
        }

        public void Update(AccountMaster accountmaster)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("UPDATE AccountMaster SET Name = @Name, Balance = @Balance,Email = @Email WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", accountmaster.Id);
                command.Parameters.AddWithValue("@Name", accountmaster.Name);
                command.Parameters.AddWithValue("@Balance", accountmaster.Balance);
                command.Parameters.AddWithValue("@Email", accountmaster.Email);


                if (command.ExecuteNonQuery() == 0)
                    throw new Exception("Customer was not found");
            }
        }

        public IEnumerable<AccountMaster> Get()
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT Id, Name, Balance FROM ACCOUNTMASTER", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return new AccountMaster
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Balance = reader.GetDecimal(2)
                        };
                    }
                }
            }
        }

        AccountMaster ICustomerService.GetById(int id)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT Id, Name, Balance,Email FROM AccountMaster WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new AccountMaster()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Balance = reader.GetDecimal(2)
                        };
                    }
                }
            }
            return null;
        }

        

        IEnumerable<AccountMaster> ICustomerService.Get()
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT Id, Name, Balance FROM ACCOUNTMASTER", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        yield return new AccountMaster
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Balance = reader.GetDecimal(2)
                        };
                    }
                }
            }
        }

        public void Login(AccountMaster am)
        {
            using(var connection = _connectionProvider.GetConnection())
            {
                try
                {

                    connection.Open();
                    var command = new SqlCommand("SELECT * FROM AccountMaster WHERE Name = @Name AND Password = @Password", connection);
                    command.Parameters.AddWithValue("@Name", am.Name);
                    command.Parameters.AddWithValue("@Password", am.Password);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    throw new Exception("Invalid username and password");
                }
            }
        }
    }
}
