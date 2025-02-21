
namespace DIWebApplication.services
{
    public class TwilioEmailService : IRRDEmailService
    {
        public TwilioEmailService()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("TwilioEmailService created");
            Console.ResetColor();
        }

        public Task SendEMailAsync(string to, string subject, string body)
        {
            return Task.Run(() =>
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Sending Email via TwilioEmailService");
                Console.ResetColor();

            });
        }
    }
}

