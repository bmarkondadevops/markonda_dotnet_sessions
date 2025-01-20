
using System;
using AccountTransferApp.Models;

namespace AccountTransferApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Create two accounts
            var fromAccount = new Account("9966636824", 1000.00);
            var toAccount = new Account("9790604084", 500.00);

            // Display initial balances
            Console.WriteLine($"Account {fromAccount.AccountNumber} balance: {fromAccount.Balance}");
            Console.WriteLine($"Account {toAccount.AccountNumber} balance: {toAccount.Balance}");

            // Transfer money from acc1 to acc2
            fromAccount.DoTransfer(toAccount, 500.00);

            // Display final balances
            Console.WriteLine($"Account {fromAccount.AccountNumber} balance after transfer: {fromAccount.Balance}");
            Console.WriteLine($"Account {toAccount.AccountNumber} balance after transfer: {toAccount.Balance}");
        }
    }
}
