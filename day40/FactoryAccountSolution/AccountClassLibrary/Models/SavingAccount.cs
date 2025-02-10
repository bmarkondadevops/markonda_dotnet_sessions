using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLibrary.Models
{
    public class SavingAccount : IAccountDepositWithdraw
    {

        private readonly string _accountNo;
        private readonly string _name;
        private double _balance;

        public SavingAccount(string accountNo, string name, double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
        }
        

        public string AccountNumber { get { return _accountNo; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }

       

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Widthdraw(double amount)
        {
            if (_balance - amount < 1000)
            {
                var ex = new Exception("No funds, min balance:1000");
                throw ex;

            }
            _balance = _balance - amount;
        }

       public void PrintBalanceSheet()
        {
                 Console.WriteLine($"Account Number: {AccountNumber}" +
                 $", Account Name: {Name}" +
                 $", Balance: {Balance}");
        }

       
    }
}
