using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Models
{
    internal abstract class Account
    {

        private string _id;
        private string _name;
        protected double _balance;
        

        public Account(string id, string name, double balance)
        {
            _name = name;
            _balance = balance;
            _id = id;
        }

        public string Id { get { return _id; } }    
        public string Name { get { return _name; } }    
        public double Balance { get { return _balance; } }

        public void Deposit(double amount) { 
            _balance += amount;
        
        }

        public abstract void WithDraw(double amount);

        public abstract string Type {  get; }
        
    }
}
