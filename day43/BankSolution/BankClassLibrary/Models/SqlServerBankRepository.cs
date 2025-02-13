using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BankClassLibrary.Models
{
    public class SqlServerBankRepository(IDbConnectionProvider connectionProvider) : IBankTransactions
    {
        private readonly IDbConnectionProvider _connectionProvider = connectionProvider;

        public void CreateAccount()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();
            Console.Write("accountNumber:" + accountNumber);

            Console.Write("Enter account holder name: ");
            string accountHolderName = Console.ReadLine();
            Console.Write("accountHolderName:" + accountHolderName);

           using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query = "INSERT INTO BankAccount (AccountNumber, AccountHolderName, Balance) VALUES (@AccountNumber, @AccountHolderName, @Balance)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    command.Parameters.AddWithValue("@AccountHolderName", accountHolderName);
                    command.Parameters.AddWithValue("@Balance", 0.00m);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Account created successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to create account.");
                    }
                }
            }
        }

        public void DepositMoney()
        {
            throw new NotImplementedException();
        }

        public void ViewAccountDetails()
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney()
        {
            throw new NotImplementedException();
        }
    }
}
