using System;
using AccountPolymorphismApp.Models;

namespace AccountPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account;//expects only subclasses
            account = new SavingAccount("101", "AccHolder1", 1000);
            PrintBalanceSheet(account);
            account = new CurrentAccount("102", "AccHolder2", 4000);
            PrintBalanceSheet(account);
        }

        //OCP-->OpenClosedPrinciple
        //Open for adding new features,without modifying existing tested code
        private static void PrintBalanceSheet(Account account)
        {
            Console.WriteLine($"Account Number: {account.Id}"+
                $", Account Name: {account.Name}"+
                $", Balance: {account.Balance}"+
                $", Account Type: {account.Type}");


            //if (account is SavingAccount)
            //{
            //    Console.WriteLine("SavingAccount");
            //}
            //else if (account is CurrentAccount)
            //{
            //    {
            //        Console.WriteLine("CurrentAccount")
            //    }

            //    //  Console.WriteLine("account type is :"+account.GetType().Name);
        }
    }
}
