using System;
using AccountWithdrawApp.Models;
using System.Linq;

namespace AccountWithdrawApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[]
        {
            new Account(12345, "Raju", 4000.00),
            new Account(56789, "Damu", 2000.00),
            new Account(23456, "Madhavi", 5000.00),
            new Account(45678, "Preemchand", 3000.00)
        };


            // Transfer amount between accounts via runtime input
            Console.WriteLine("\nTransfer Amount Between Accounts:");

            int fromAccountNumber;
            while (true)
            {
                Console.Write("Enter source account number: ");
                if (int.TryParse(Console.ReadLine(), out fromAccountNumber))
                {
                    if (fromAccountNumber != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Source account not found. Please enter AccountNumber again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid AccountNumber.");
                }
            }
            int toAccountNumber;
            while (true)
            {
                Console.Write("Enter destination account number: ");
                if (int.TryParse(Console.ReadLine(), out toAccountNumber))
                {
                    //Console.WriteLine("Enter destination AccountNumber :" + toAccountNumber);
                   
                    if (toAccountNumber != null && toAccountNumber != fromAccountNumber)
                    {
                        break;
                    }
                    else if (toAccountNumber == fromAccountNumber)
                    {
                        Console.WriteLine("Source and destination accounts cannot be the same. Please check AccountNumbers again.");
                    }
                    else
                    {
                        Console.WriteLine("Destination account not found. Please enter AccountNumber again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid AccountNumber.");
                }
            }

            double transferAmount;
            while (true)
            {
                Console.Write("Enter the amount to transfer: ");
                if (double.TryParse(Console.ReadLine(), out transferAmount) && transferAmount > 0)
                    break;
                else
                    Console.WriteLine("Invalid transfer amount. Please enter valid amount.");
            }

            TransferAmount(accounts, fromAccountNumber, toAccountNumber, transferAmount);

            // Display updated balances after transfer
            Console.WriteLine("\nUpdated Balances After Transfer:");
            DisplayBalances(accounts);
        }

        static void TransferAmount(Account[] accounts, int fromAccountNumber, int toAccountNumber, double amount)
        {
            Account fromAccount = null;
            Account toAccount = null;

            foreach (var account in accounts)
            {
                if (account.AccountNumber == fromAccountNumber)
                {
                    fromAccount = account;
                }
                else if (account.AccountNumber == toAccountNumber)
                {
                    toAccount = account;
                }

                // If both accounts are found, we can break out of the loop
                if (fromAccount != null && toAccount != null)
                {
                    break;
                }
            }

            if (fromAccount == null)
            {
                Console.WriteLine($"Source account {fromAccountNumber} not found.");
                return;
            }

            if (toAccount == null)
            {
                Console.WriteLine($"Destination account {toAccountNumber} not found.");
                return;
            }

            if (fromAccount == toAccount)
            {
                Console.WriteLine("Source and destination accounts are the same. No transfer needed.");
                return;
            }

            if (!fromAccount.Withdraw(amount))
            {
                Console.WriteLine("Insufficient funds in the source account.");
                return;
            }

            toAccount.Deposit(amount);


        }

        static void DisplayBalances(Account[] accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"{account.Name} - Balance: {account.Balance}");
            }
        }
    }
}
