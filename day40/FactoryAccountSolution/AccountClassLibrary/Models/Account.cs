using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassLibrary.Models
{
    public class Account
    {
        private string _id;
        private string _name;
        protected double _balance;
        private TypeAccount _accountype;

        public Account(string id, string name, double balance,TypeAccount accounttype)
        {

            _name = name;
            _balance = balance;
            _id = id;
            _accountype = accounttype;
        }

        public double Balance { get { return _balance; } }
        public string Name { get { return _name; } }       
        public string Id  { get { return _id; }  }
        public TypeAccount AccountType { get { return _accountype; } }


        public override string ToString()
        {
            return $"Id::{_id},Name::{_name}, Balance::{_balance},AccountType:{_accountype}";
        }

    }
}
