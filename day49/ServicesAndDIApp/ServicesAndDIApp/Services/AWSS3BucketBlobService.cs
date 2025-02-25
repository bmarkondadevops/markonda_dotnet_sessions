
namespace ServicesAndDIApp.Services
{
    public class AWSS3BucketBlobService : IRRDBlobService
    {
        public AWSS3BucketBlobService() {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("AWSS3BucketBlobService created");
            Console.ResetColor();

        }
        public Task Log(string to, string subject, string body)
        {
            return Task.Run(() => {

                //real api call to twilios
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"s3 bucket  {body}");
                Console.ResetColor();



            });

        }
    }
}
