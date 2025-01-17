using System;
using System.Xml.Linq;


namespace ArrayOfAccountsApp.Models
{
    internal class Account
    {
        private readonly string _accountHolderName;
        private double _balance;


        public Account(string accountHolderName, double balance)
        {
            _accountHolderName = accountHolderName;
            _balance = balance;
        }

        public string AccountHolderName
        {

            get { 
                return _accountHolderName; 
            }
        }

        public double Balance
        {

            get { 
                return _balance; 
            }
        }

    }
}
