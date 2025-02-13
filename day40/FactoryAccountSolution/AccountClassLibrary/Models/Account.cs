using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLibrary.Models
{
    public class Account:IAccountDepositWithdraw
    {
        private readonly string _accountNo;
        private readonly string _name;
        protected double _balance;


        public Account() { }
        public Account(string accountNo, string name, double balance)
        {
            _accountNo = accountNo;
            _name = name;
            _balance = balance;
        }


        public string AccountNumber { get { return _accountNo; } }
        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }

        public virtual void Deposit(double amount)
        {
            _balance += amount;
        }

        public virtual void Widthdraw(double amount)
        {
            if (_balance - amount < 500)
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
