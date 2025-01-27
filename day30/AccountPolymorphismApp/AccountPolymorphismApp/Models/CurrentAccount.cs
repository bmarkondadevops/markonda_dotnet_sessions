using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Models
{
    internal class CurrentAccount : Account
    {
        public CurrentAccount(string id, string name, double balance) : base(id, name, balance)
        {
        }

        public override string Type {
            get {
                return "CurrentAccount";
            }
        }

        public override void WithDraw(double amount)
        {
            if (_balance - amount < -5000)
            {
                var ex = new Exception("Available credit limit reached.. 5000");
                throw ex;
            }

            _balance = _balance - amount;
        }
    }
}
