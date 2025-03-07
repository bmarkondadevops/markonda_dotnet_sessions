using System;
using System.Collections.Generic;
using System.Data;
using System.Transactions;
using BankApplicationV2.Domain;
using BankApplicationV2.DTOs;
using BankApplicationV2.Models;
using BankApplicationV2.Services;
using Microsoft.Data.SqlClient;



namespace BankApplicationV2.Services
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
                var command = new SqlCommand("UPDATE AccountMaster SET Name = @Name, Balance = @Balance WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", accountmaster.Id);
                command.Parameters.AddWithValue("@Name", accountmaster.Name);
                command.Parameters.AddWithValue("@Balance", accountmaster.Balance);
                //command.Parameters.AddWithValue("@Email", accountmaster.Email);

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

        public void login(AccountMaster accountMaster)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM AccountMaster WHERE Name = @Name and Password=@Password", connection);
                command.Parameters.AddWithValue("@Name", accountMaster.Name);
                command.Parameters.AddWithValue("@Password", accountMaster.Password);

            }
        }



        /* ==================================================*/
        //Account Transaction 
        public IEnumerable<AccountTransactionAllDTO> GetTransactions(int accountId)
        {
            List<AccountTransactionAllDTO> transactions = new List<AccountTransactionAllDTO>();

            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM AccountTransaction WHERE AccountMasterId = @AccountMasterId", connection);
                command.Parameters.AddWithValue("@AccountMasterId", accountId);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    transactions.Add(new AccountTransactionAllDTO
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        AccountMasterId = Convert.ToInt32(reader["AccountMasterId"]),
                        Name = reader["Name"].ToString(),
                        Amount = Convert.ToDecimal(reader["Amount"]),
                        TransactionType = reader["TransactionType"].ToString(),
                        Date = Convert.ToDateTime(reader["Date"]) // Convert date from database
                    });
                }
                return transactions;
            }          
            
        }
        
        public void CreateTransaction(AccountTransactionDTO transaction)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                // Update account balance
                UpdateAccountBalance(transaction.AccountMasterId, transaction.Amount, transaction.TransactionType);

                // Traditional SQL query without parameterization (NOT RECOMMENDED)
                string query = $"INSERT INTO AccountTransaction (AccountMasterId, Name, Amount, TransactionType, Date) VALUES ({transaction.AccountMasterId}, '{transaction.Name}', {transaction.Amount}, '{transaction.TransactionType}', '{transaction.Date.ToString("yyyy-MM-dd HH:mm:ss")}')";

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateTransaction(AccountTransactionDTO transaction)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                // Reverse previous transaction effect on balance
                ReverseTransactionEffect(transaction.Id);

                // Update account balance with new values
                UpdateAccountBalance(transaction.AccountMasterId, transaction.Amount, transaction.TransactionType);

                // Traditional SQL query without parameterization (NOT RECOMMENDED)
                string query = $"UPDATE AccountTransaction SET Name = '{transaction.Name}', Amount = {transaction.Amount}, TransactionType = '{transaction.TransactionType}', Date = '{transaction.Date.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE Id = {transaction.Id}";

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }
        }

        private void UpdateAccountBalance(int accountId, decimal amount, string transactionType)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query;

                if (transactionType == "Credit")
                {
                    query = $"UPDATE AccountMaster SET Balance += {amount} WHERE Id = {accountId}";
                }
                else if (transactionType == "Debit")
                {
                    query = $"UPDATE AccountMaster SET Balance -= {amount} WHERE Id = {accountId}";
                }
                else
                {
                    throw new ArgumentException("Invalid transaction type.");
                }

                SqlCommand command = new SqlCommand(query, connection);

                command.ExecuteNonQuery();
            }
        }

        private void ReverseTransactionEffect(int transactionId)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query = $"SELECT * FROM AccountTransaction WHERE Id = {transactionId}";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int accountId = Convert.ToInt32(reader["AccountMasterId"]);
                    decimal amount = Convert.ToDecimal(reader["Amount"]);
                    string transactionType = reader["TransactionType"].ToString();

                    if (transactionType == "Credit")
                    {
                        UpdateAccountBalance(accountId, amount, "Debit"); // Reverse credit by debiting
                    }
                    else if (transactionType == "Debit")
                    {
                        UpdateAccountBalance(accountId, amount, "Credit"); // Reverse debit by crediting
                    }
                }
            }
        }
    }
}
