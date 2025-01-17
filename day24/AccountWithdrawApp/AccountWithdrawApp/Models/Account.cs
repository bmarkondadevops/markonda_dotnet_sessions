using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountWithdrawApp.Models
{
    internal class Account
    {
        private readonly int _accountNumber;
        private readonly string _name;
        private double _balance;
        private const double MIN_BALANCE = 500;


        public Account(int accountNumber, string name, double balance)
        {
            _accountNumber = accountNumber;
            _name = name;
            _balance = balance;
        }

        //public Account(int accountNumber,double balance)
        //{
        //    _accountNumber = accountNumber;
        //    _balance = MIN_BALANCE;
        //}

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount > _balance)
            {
                return false; // Insufficient funds
            }
            _balance -= amount;
            return true;
        }


        public double Balance
        {

            get
            {
                return _balance;
            }
        }

        public string Name
        {

            get
            {
                return _name;
            }
        }

        public int AccountNumber
        {

            get
            {
                return _accountNumber;
            }
        }

    }

}
