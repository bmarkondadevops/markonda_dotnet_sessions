using System.Security.Principal;
using ArrayOfAccountsApp.Models;

namespace ArrayOfAccountsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of accounts
            Account[] accounts = new Account[]
            {
            new Account("Markonda", 10000.00),
            new Account("Ramana", 20000.00),
            new Account("Jitendra", 50000.00),
            new Account("Richard", 30000.00),
            new Account("Lakshi", 70000.00)
            };

            // Find and display the richest account holder
            Account richestAccount = FindRichestAccount(accounts);

            if (richestAccount != null)
            {
                Console.WriteLine($"The richest account holder is {richestAccount.AccountHolderName} with a balance of {richestAccount.Balance:C}");
            }
            else
            {
                Console.WriteLine("No accounts found.");
            }

            // Display account holders with names >= 8 characters
            Console.WriteLine("\nAccount Holders Names >= 8 Characters");
            DisplayLongNames(accounts);
        }

        static Account FindRichestAccount(Account[] accounts)
        {
            if (accounts.Length == 0)
                return null;

            Account richest = accounts[0];

            foreach (var account in accounts)
            {
                if (account.Balance > richest.Balance)
                {
                    richest = account;
                }
            }

            return richest;
        }



        static void DisplayLongNames(Account[] accounts)
        {
            int count = 0;
            bool flag = false;
            foreach (var account in accounts)
            {
                if (account.AccountHolderName.Length >= 8)
                {
                    Console.WriteLine($"{account.AccountHolderName} - Balance: {account.Balance}");
                }
                else
                {
                    flag = true;
                    count++;
                }
            }
           
            if (flag == true && count== accounts.Length)
            {
                Console.WriteLine("No account holders have names with 8 or more characters.");
            }
        }
    }
}
