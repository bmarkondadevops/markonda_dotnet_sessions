using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryClassLibrary1.Models
{
    public interface IAccountDepositWithdraw
    {
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
        void PrintBalanceSheetInfo();
    }
}
