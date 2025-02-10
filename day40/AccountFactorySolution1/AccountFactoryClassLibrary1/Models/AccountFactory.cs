using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountFactoryClassLibrary1.Models
{
    public class AccountFactory
    {
       public static IAccountDepositWithdraw CreateAccount(AccountType type, params object[] parameters)
    {
        switch (type)
        {
            case AccountType.Basic:
                return new Account();
            case AccountType.Saving:
                if (parameters.Length != 1 || !(parameters[0] is decimal))
                    throw new ArgumentException("Invalid parameter for SavingAccount.");
                return new SavingAccount((decimal)parameters[0]);
            case AccountType.Current:
                if (parameters.Length != 1 || !(parameters[0] is decimal))
                    throw new ArgumentException("Invalid parameter for CurrentAccount.");
                return new CurrentAccount((decimal)parameters[0]);
            default:
                throw new ArgumentException("Unsupported account type.");
        }
    }
    }
}
