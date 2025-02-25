namespace ServicesAndDIApp.Services
{
    public interface IRRDBlobService
    {
      Task  Log(string to,string subject,string body);
    }
}
