
using System;
using AccountFactoryClassLibrary1.Models;

namespace AccountFactoryConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a basic account
            var basicAccount = AccountFactory.CreateAccount(AccountType.Basic);            
            basicAccount.Deposit(1000);
            basicAccount.Withdraw(500);
            basicAccount.PrintBalanceSheetInfo();

            // Create a saving account with an interest rate of 5%
            var savingAccount = AccountFactory.CreateAccount(AccountType.Saving, 5m);
            savingAccount.Deposit(2000);
            savingAccount.Withdraw(700);
            savingAccount.PrintBalanceSheetInfo();

            // Create a current account with an overdraft limit of $1000
            var currentAccount = AccountFactory.CreateAccount(AccountType.Current, 1000m);
            currentAccount.Deposit(1500);
            currentAccount.Withdraw(2000); // This will use overdraft limit.
            currentAccount.PrintBalanceSheetInfo();
        }
    }
}
