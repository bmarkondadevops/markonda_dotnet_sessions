
using LoginMiddlewareExcerciseClassOriented.Models;

namespace LoginMiddlewareExcerciseClassOriented.Services
{
    public class RRD_VPNLoginService : IRRDLoginService
    {
        public RRD_VPNLoginService()
        {
            Console.WriteLine("VPN Login Service Initiated");
        }

        public bool LoginAuthenticationAsync(string username)
        {
           
            LoginDataBase data = new LoginDataBase();
            bool result = data.isAuthenticated(username);
            return result;            
           
        }

        public bool LoginAuthorizationAsync(string password)
        {
            LoginDataBase data = new LoginDataBase();
            bool result = data.isAuthorised(password);
            return result;
        }
    }
}
