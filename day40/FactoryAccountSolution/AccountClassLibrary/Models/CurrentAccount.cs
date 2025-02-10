using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLibrary.Models
{
    public class CurrentAccount : Account, IAccountDepositWithdraw
    {
        public CurrentAccount(string id, string name, double balance,TypeAccount accounttype) : base(id, name, balance,accounttype)
        {
        }

        public void Deposit(double amount)
        {
            _balance += amount;
           
        }

        public void Widthdraw(double amount)
        {
            if (_balance - amount < -5000)
            {
                var ex = new Exception("Available credit limit reached!! 5000");
                throw ex;

            }
            _balance = _balance - amount;

        }

        public void PrintBalanceSheet(Account account)
        {
            Console.WriteLine($"Account Number: {account.Id}" +
            $", Account Name: {account.Name}" +
            $", Balance: {account.Balance}" +
            $", Account Type: {account.AccountType.ToString()}");
        }
    }
}
