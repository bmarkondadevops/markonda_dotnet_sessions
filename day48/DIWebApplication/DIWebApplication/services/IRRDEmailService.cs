namespace DIWebApplication.services
{
    public interface IRRDEmailService
    {
        Task SendEMailAsync(string to,String subject,string body);
    }
}
