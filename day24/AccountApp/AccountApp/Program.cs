using AccountApp.Models;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
            // CaseStudy3();
        }

        private static void CaseStudy3()
        {
            //Anonymous object

            PrintDetails(new Account(1003, "Minu", 3000));

        }

        private static void CaseStudy2()
        {
            Account venkatAccount = new Account(1002, "Venkat");
            PrintDetails(venkatAccount);
            venkatAccount.Deposit(1500);
            PrintDetails(venkatAccount);
        }

        private static void CaseStudy1()
        {
            Account acc1 = new Account(1001, "Kannan", 1000);
            acc1.Withdraw(501);

            PrintDetails(acc1);

        }

        private static void PrintDetails(Account account)
        {
            Console.WriteLine($"name is {account.Name} balance is {account.Balance} and acconot is {account.AccountNumber}");
        }
    }
}
