using Bankpplication.DTOs;
using Bankpplication.Models;
using Microsoft.Data.SqlClient;

namespace Bankpplication.Services
{
    public class AccountTransactionService : IAccountTransactionService
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public AccountTransactionService(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public List<AccountTransactionDTO> GetAllAccountTransactions()
        {
            List<AccountTransactionDTO> transactions = new List<AccountTransactionDTO>();

            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query = "SELECT Id, AccountMasterId, Name, Amount, TransactionType, Date FROM AccountTransactions";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transactions.Add(new AccountTransactionDTO
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            AccountMasterId = Convert.ToInt32(reader["AccountMasterId"]),
                            Name = reader["Name"].ToString(),
                            Amount = Convert.ToDecimal(reader["Amount"]),
                            TransactionType = reader["TransactionType"].ToString(),
                            Date = Convert.ToDateTime(reader["Date"])
                        });
                    }
                }
            }

            return transactions;
        }

        public AccountTransactionDTO GetAccountTransactionById(int id)
        {
            AccountTransactionDTO transaction = null;

            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query = "SELECT Id, AccountMasterId, Name, Amount, TransactionType, Date FROM AccountTransactions WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        transaction = new AccountTransactionDTO
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            AccountMasterId = Convert.ToInt32(reader["AccountMasterId"]),
                            Name = reader["Name"].ToString(),
                            Amount = Convert.ToDecimal(reader["Amount"]),
                            TransactionType = reader["TransactionType"].ToString(),
                            Date = Convert.ToDateTime(reader["Date"])
                        };
                    }
                }
            }

            return transaction;
        }

        public AccountTransactionDTO CreateAccountTransaction(AccountTransactionDTO accountTransactionDTO)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query = "INSERT INTO AccountTransactions (AccountMasterId, Name, Amount, TransactionType, Date) VALUES (@AccountMasterId, @Name, @Amount, @TransactionType, @Date); SELECT SCOPE_IDENTITY() AS NewId";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@AccountMasterId", accountTransactionDTO.AccountMasterId);
                command.Parameters.AddWithValue("@Name", accountTransactionDTO.Name);
                command.Parameters.AddWithValue("@Amount", accountTransactionDTO.Amount);
                command.Parameters.AddWithValue("@TransactionType", accountTransactionDTO.TransactionType);
                command.Parameters.AddWithValue("@Date", accountTransactionDTO.Date);

                int newId = Convert.ToInt32(command.ExecuteScalar());

                return new AccountTransactionDTO
                {
                    Id = newId,
                    AccountMasterId = accountTransactionDTO.AccountMasterId,
                    Name = accountTransactionDTO.Name,
                    Amount = accountTransactionDTO.Amount,
                    TransactionType = accountTransactionDTO.TransactionType,
                    Date = accountTransactionDTO.Date
                };
            }
        }

        public AccountTransactionDTO UpdateAccountTransaction(int id, AccountTransactionDTO updatedAccountTransactionDTO)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query = "UPDATE AccountTransactions SET AccountMasterId = @AccountMasterId, Name = @Name, Amount = @Amount, TransactionType = @TransactionType, Date = @Date WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@AccountMasterId", updatedAccountTransactionDTO.AccountMasterId);
                command.Parameters.AddWithValue("@Name", updatedAccountTransactionDTO.Name);
                command.Parameters.AddWithValue("@Amount", updatedAccountTransactionDTO.Amount);
                command.Parameters.AddWithValue("@TransactionType", updatedAccountTransactionDTO.TransactionType);
                command.Parameters.AddWithValue("@Date", updatedAccountTransactionDTO.Date);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return updatedAccountTransactionDTO;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool DeleteAccountTransaction(int id)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query = "DELETE FROM AccountTransactions WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public int HeadCount()
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT COUNT(*) FROM AccountTransaction", connection);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

    }
}
