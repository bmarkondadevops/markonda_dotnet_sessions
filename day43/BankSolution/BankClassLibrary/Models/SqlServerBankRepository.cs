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

            Console.Write("Enter account holder name: ");
            string accountHolderName = Console.ReadLine();

            Console.Write("Enter initial amount: ");
            decimal initialAmount =System.Convert.ToDecimal(Console.ReadLine());


            using (var connection = _connectionProvider.GetConnection())
            {
                connection.Open();

                string query = "INSERT INTO BankAccount (AccountNumber, AccountHolderName, Balance) VALUES (@AccountNumber, @AccountHolderName, @Balance)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    command.Parameters.AddWithValue("@AccountHolderName", accountHolderName);
                    command.Parameters.AddWithValue("@Balance", initialAmount);

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
            Console.Write("Enter account ID: ");
            int accountId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter amount to deposit: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
           

            using (SqlConnection connection = new SqlConnection("_connectionProvider"))
            {
                connection.Open();

                // Check if account exists
                string queryCheckAccount = "SELECT * FROM BankAccount WHERE AccountID = @AccountID";
                decimal amtDeposit = "update bankaccount set balance=2000 where accountid = accountid";
                using (SqlCommand commandCheckAccount = new SqlCommand(queryCheckAccount, connection))
                {
                    commandCheckAccount.Parameters.AddWithValue("@AccountID", accountId);

                    using (SqlDataReader reader = commandCheckAccount.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            Console.WriteLine("Account not found.");
                            return;
                        }
                        else {
                            
                            var cmd = new SqlCommand("update BankAccount set Balance=2000 where AccountID = accountId", con);
                            cmd.Parameters.AddWithValue("@Description", todo.Description);
                            cmd.ExecuteNonQuery();                           

                        }
                    }

                }
            }
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
