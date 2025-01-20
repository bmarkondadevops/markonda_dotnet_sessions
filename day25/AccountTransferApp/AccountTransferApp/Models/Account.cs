using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransferApp.Models
{
    internal class Account
    {

        private string _accountNumber; 
        private double _balance;

        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public Account(string accountNumber, double initialBalance)
        {
            _accountNumber = accountNumber;
            _balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited {amount} into account {AccountNumber}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew {amount} from account {AccountNumber}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }

        }


        public void DoTransfer(Account destinationAccount, double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                Withdraw(amount);
                destinationAccount.Deposit(amount);
                Console.WriteLine($"Transferred {amount} from account {AccountNumber} to account {destinationAccount.AccountNumber}.");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid transfer amount.");
            }
        }
    }
}
