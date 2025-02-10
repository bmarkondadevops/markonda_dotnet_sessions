using System.Security.Principal;
using AccountClassLibrary.Models;

namespace AccountFactoryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accountFactory = new AccountFactory();
            
            //Saving account 
            IAccountDepositWithdraw sAccount = accountFactory.AccountCreation(TypeAccount.SAVING);
            sAccount.Deposit(500);
            sAccount.PrintBalanceSheet();

            //Current account
            IAccountDepositWithdraw cAccount = accountFactory.AccountCreation(TypeAccount.CURRENT);
            cAccount.Deposit(1000);
            cAccount.PrintBalanceSheet();


        }

      
    }
}
