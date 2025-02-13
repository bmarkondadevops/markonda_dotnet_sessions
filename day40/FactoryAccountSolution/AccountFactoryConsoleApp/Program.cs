using System.Security.Principal;
using System.Xml.Linq;
using AccountClassLibrary.Models;

namespace AccountFactoryConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accountFactory = new AccountFactory();



            //Saving account 
            //IAccountDepositWithdraw sAccount = accountFactory.AccountCreation(TypeAccount.SAVING, Account ac);
            SavingAccount ac = accountFactory.AccountCreation(TypeAccount.SAVING, Account account);
            ac.Deposit(500);
            ac.PrintBalanceSheet();

           



            //Current account
            //IAccountDepositWithdraw cAccount = accountFactory.AccountCreation(TypeAccount.CURRENT);
            //cAccount.Deposit(1000);
            //cAccount.PrintBalanceSheet();


        }

      
    }
}
