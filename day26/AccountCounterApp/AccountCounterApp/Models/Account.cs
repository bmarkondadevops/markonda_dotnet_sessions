using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCounterApp.Models
{
    internal class Account
    {
        private readonly int _accountNumber;
        private readonly string _name;
        private double _balance;
        private const double MIN_BALANCE = 500;
        private static int _instanceCounter;//intiliaze it via a method c


        //private static int LoadLastCounterValueFromDB() {

        //    //connecting to db
        //    return 1000;
        //}

        static Account()//static block
        {
            Console.WriteLine("static constructor");
            Console.WriteLine("called only once in entired project");
            _instanceCounter = 1000;
        }
        public Account(int accountNumber, string name, double balance)
        {
            Console.WriteLine("inside constrcutor");
            _accountNumber = accountNumber;
            _name = name;
            _balance = balance;
            _instanceCounter++;
        }

        //public Account(int accountNumber, string name)
        //{
        //    _accountNumber = accountNumber;
        //    _name = name;
        //    _balance = MIN_BALANCE;
        //    _instanceCounter++;
        //}

        public void Deposit(double amount)
        {

            _balance = _balance + amount;
        }

        public void Withdraw(double amount)
        {

            if (_balance - amount > MIN_BALANCE)
                _balance = _balance - amount;

            //will throw exeception later,
            //throw new Exception("Insufficient balance");

        }

        public int InstanceCounter
        {

            get { return _instanceCounter; }
        }

        public double Balance
        {

            get { return _balance; }
        }

        public string Name
        {

            get { return _name; }
        }

        public int AccountNumber
        {


            get
            {


                return _accountNumber;

            }
        }


        public static int HeadCount//static method,affinity ,uses only sttatic variables
        {
            get
            {

                return _instanceCounter;
            }

        }


    }
}
