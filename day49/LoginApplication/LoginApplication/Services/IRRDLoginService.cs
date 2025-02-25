namespace LoginMiddlewareExcerciseClassOriented.Services
{
    public interface IRRDLoginService
    {
        bool LoginAuthenticationAsync(string username);
        bool LoginAuthorizationAsync(string password);
    }
}
