using BankApplicationV2.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using BankApplicationV2.Models;
using System.Transactions;

namespace BankApplicationV2.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public TransactionService(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        public void PerformTransaction(AccountTransactionDTO transactionDTO)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                UpdateAccountBalance(transactionDTO.AccountMasterId, transactionDTO.Amount, transactionDTO.TransactionType);

                var command = new SqlCommand("INSERT INTO AccountTransaction (AccountMasterId, Name, Amount, TransactionType, Date) VALUES (@AccountMasterId, @Name, @Amount, @TransactionType, GETDATE())", connection);
                command.Parameters.AddWithValue("@AccountMasterId", transactionDTO.AccountMasterId);
                command.Parameters.AddWithValue("@Name", transactionDTO.Name);
                command.Parameters.AddWithValue("@Amount", transactionDTO.Amount);
                command.Parameters.AddWithValue("@TransactionType", transactionDTO.TransactionType);

                command.ExecuteNonQuery();
            }
        }



        public IEnumerable<AccountTransactionDTO> GetTransactionHistory(int accountMasterId)
        {
            List<AccountTransactionDTO> transactions = new List<AccountTransactionDTO>();

            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM AccountTransaction WHERE AccountMasterId = @AccountMasterId", connection);
                command.Parameters.AddWithValue("@AccountMasterId", accountMasterId);

                using (var reader = command.ExecuteReader())
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



        public void UpdateAccountBalance(int accountId, decimal amount, string transactionType)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query;

                if (transactionType == "Deposit")
                {
                    query = $"UPDATE AccountMaster SET Balance += {amount} WHERE Id = {accountId}";
                }
                else if (transactionType == "Withdrawal")
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




        /*
        public void UpdateAmount(AccountTransactionDTO transactionDTO)
        {
            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                decimal amountToUpdate = transactionDTO.Amount;

                if (transactionDTO.TransactionType == "Withdrawal")
                {
                    amountToUpdate = -transactionDTO.Amount; // Subtract for withdrawal
                }


                // Update account balance
                var updateBalanceCommand = new SqlCommand("UPDATE AccountMaster SET Balance = Balance + @Amount WHERE Id = @AccountMasterId", connection);
                updateBalanceCommand.Parameters.AddWithValue("@Amount", amountToUpdate);
                updateBalanceCommand.Parameters.AddWithValue("@AccountMasterId", transactionDTO.AccountMasterId);
                updateBalanceCommand.ExecuteNonQuery();

                // Insert transaction into AccountTransaction table
                var insertTransactionCommand = new SqlCommand("INSERT INTO AccountTransaction (AccountMasterId, Name, Amount, TransactionType, Date) VALUES (@AccountMasterId, @Name, @Amount, @TransactionType, GETDATE())", connection);
                insertTransactionCommand.Parameters.AddWithValue("@AccountMasterId", transactionDTO.AccountMasterId);
                insertTransactionCommand.Parameters.AddWithValue("@Name", transactionDTO.Name);
                insertTransactionCommand.Parameters.AddWithValue("@Amount", transactionDTO.Amount);
                insertTransactionCommand.Parameters.AddWithValue("@TransactionType", transactionDTO.TransactionType);

                insertTransactionCommand.ExecuteNonQuery();
            }
        }
        */


        /*
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

        */


        public void ReverseTransactionEffect(int transactionId)
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
        /*
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
        */

    }
}
