using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLibrary.Models
{
    public interface IAccountDepositWithdraw
    {
        public void Widthdraw(double amount);
        public void Deposit(double amount);

        public void PrintBalanceSheet(Account account);
    }
}
