using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AccountClassLibrary.Models
{
    public class AccountFactory
    {
        public IAccountDepositWithdraw AccountCreation(TypeAccount accountType)
        {
            if (accountType == TypeAccount.SAVING)

                return new SavingAccount("1001", "Markonda", 50000);


            else if (accountType == TypeAccount.CURRENT)

                return new CurrentAccount("1002", "Kannan", 100000);
            else

                return new Account("5555", "Rama", 500);

        }
    }
}
