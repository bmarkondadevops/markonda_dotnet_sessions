using BankClassLibrary.Models;

namespace BankConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbConnectionProvider = new SqlServerDbConnectionProvider("Data Source=CHLAPDMARKOND\\SQLEXPRESS;Initial Catalog=rrd_db1;Integrated Security=True;Trust Server Certificate=True");
            var toDoItemRepository = new SqlServerBankRepository(dbConnectionProvider);

            SqlServerBankRepository bankRepository = new SqlServerBankRepository(dbConnectionProvider);


            Console.WriteLine("Bank Application");

            while (true)
            {
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. View Account Details");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bankRepository.CreateAccount();
                        break;
                    case 2:
                        bankRepository.DepositMoney();
                        break;
                    case 3:
                        bankRepository.WithdrawMoney();
                        break;
                    case 4:
                        bankRepository.ViewAccountDetails();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

    }
 }

