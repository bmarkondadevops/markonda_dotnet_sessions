using AccountCommonLibrary;


namespace CustomExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(22863, "Markonda", 1000);
            try
            {
                account.Withdraw(account,1000);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
        }
    }
}
