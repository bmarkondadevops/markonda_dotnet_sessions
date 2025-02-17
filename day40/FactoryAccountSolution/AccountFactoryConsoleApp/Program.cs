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

            var account = new Account();

            //Saving account 
            //IAccountDepositWithdraw sAccount = accountFactory.AccountCreation(TypeAccount.SAVING, Account ac);
            SavingAccount ac =(SavingAccount) accountFactory.AccountCreation(TypeAccount.SAVING, account);
           
            ac.Deposit(500);
            ac.PrintBalanceSheet();

           



            //Current account
            //IAccountDepositWithdraw cAccount = accountFactory.AccountCreation(TypeAccount.CURRENT);
            //cAccount.Deposit(1000);
            //cAccount.PrintBalanceSheet();


        }

      
    }
}
