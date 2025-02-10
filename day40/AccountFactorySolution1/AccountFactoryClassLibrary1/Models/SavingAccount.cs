using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryClassLibrary1.Models
{
    public class SavingAccount : IAccountDepositWithdraw
    {
        public decimal Balance { get; private set; }
        public decimal InterestRate { get; set; }

        public SavingAccount(decimal interestRate)
        {
            InterestRate = interestRate;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
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
            Console.WriteLine($"Saving Account Balance: {Balance}, Interest Rate: {InterestRate}%");
        }
    }
}
