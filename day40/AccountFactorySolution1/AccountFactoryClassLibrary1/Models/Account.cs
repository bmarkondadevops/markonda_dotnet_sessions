using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccountFactoryClassLibrary1.Models
{
    public class Account: IAccountDepositWithdraw
    {
        public decimal Balance { get; private set; }
        
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
            Console.WriteLine($"Account Balance: {Balance}");
        }

    }
}
