using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryClassLibrary1.Models
{
    public class CurrentAccount : IAccountDepositWithdraw
    {
        public decimal Balance { get; private set; }
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(decimal overdraftLimit)
        {
            OverdraftLimit = overdraftLimit;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance + OverdraftLimit)
            {
                Console.WriteLine("Transaction exceeds overdraft limit.");
                return;
            }
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void PrintBalanceSheetInfo()
        {
            Console.WriteLine($"Current Account Balance: {Balance}, Overdraft Limit: {OverdraftLimit}");
        }
    }
}

