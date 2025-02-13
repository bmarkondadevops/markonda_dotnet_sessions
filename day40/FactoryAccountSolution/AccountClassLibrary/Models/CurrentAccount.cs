using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLibrary.Models
{
    public class CurrentAccount : Account
    {
        //private readonly string _accountNo;
        //private readonly string _name;
        //private double _balance;

        public CurrentAccount(string accountNo, string name, double balance) : base(accountNo, name, balance)
        {
        }


        //public CurrentAccount(string accountNo, string name, double balance)
        //{
        //    _accountNo = accountNo;
        //    _name = name;
        //    _balance = balance;
        //}

        //public string AccountNumber { get { return _accountNo; } }
        //public string Name { get { return _name; } }
        //public double Balance { get { return _balance; } }

        public override void Deposit(double amount)
        {
            _balance += amount;
           
        }

        public override void Widthdraw(double amount)
        {
            if (_balance - amount < -5000)
            {
                var ex = new Exception("Available credit limit reached!! 5000");
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
