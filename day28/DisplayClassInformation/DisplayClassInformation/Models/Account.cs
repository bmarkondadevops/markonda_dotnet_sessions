using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayClassInformation.Models
{
    internal class Account
    {
        private  int _empId;
        private string _empName;
        private double _balance;
        public Account() { }
        public Account(int empId, string empName, double balance)
        {
            this._empId = empId;
            this._empName = empName;
            this._balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(int amount)
        {
            if (Balance >= amount)
                Balance -= amount;
        }

        public int EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }                                                                                                   

        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }

        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
