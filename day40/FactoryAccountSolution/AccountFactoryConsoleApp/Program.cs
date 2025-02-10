using System.Security.Principal;
using AccountClassLibrary.Models;

namespace AccountFactoryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account;
            account = new SavingAccount("10001", "Markonda", 5000,TypeAccount.SAVING);
           // account.Withdra(500); //not calling
            PrintBalanceSheet(account);          
        }

        private static void PrintBalanceSheet(Account account)
        {
            Console.WriteLine($"Account Number: {account.Id}" +
                $", Account Name: {account.Name}" +
                $", Balance: {account.Balance}" +
                $", Account Type: {account.AccountType.ToString()}");
        }
    }
}
