using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassLibrary.Models
{
    public interface IBankTransactions
    {
        void CreateAccount();
        void DepositMoney();
        void WithdrawMoney();
        void ViewAccountDetails();



    }
}
