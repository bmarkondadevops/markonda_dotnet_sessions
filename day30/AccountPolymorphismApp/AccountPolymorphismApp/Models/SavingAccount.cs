using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Models
{
    internal class SavingAccount(string id, string name, double balance) : Account(id, name, balance)
    { 

        public override void WithDraw(double amount)
        {
            if (_balance - amount < 1000)
            {
                var ex = new Exception("No sufficient fund. Minimum balance : 1000");
                throw ex;
            }
            _balance=_balance - amount;
        }

        public override string Type
        {
            get
            {
                return "SavingAccount";
            }
        }
    }
}
