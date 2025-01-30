using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommonLibrary
{
    public class InsufficientFundsException : Exception
    {

        private Account _accountHolder;//HasA relationship
        public InsufficientFundsException(Account account)
        {
            _accountHolder = account;
        }


        public override string Message
        {
            get
            {

                return $"account holder:{_accountHolder.Name} , doesn't have sufficient for withdraw of balance is only :{_accountHolder.Balance}";
            }
        }
    }
}
