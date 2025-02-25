using LoginMiddlewareExcerciseClassOriented.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LoginMiddlewareExcerciseClassOriented.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RRD_LoginAutharization_Middleware
    {
        private readonly RequestDelegate _next;

        public RRD_LoginAutharization_Middleware(RequestDelegate next)
        {
            Console.WriteLine("Login Authorization Initiated ");
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IRRDLoginService rRDLoginService)
        {

            Console.WriteLine("Pre Authorization Process Started");
            string password = "Password";
            bool result = rRDLoginService.LoginAuthorizationAsync(password);
            if (!result)
            {
                Console.WriteLine("Short Circuited: Password incorrect. Not Autorised to to Access");
            }
            else {
                Console.WriteLine("Password is correct");
                await _next(httpContext);
                Console.WriteLine("Post Authorization Check");
            }
               
           
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class RRD_LoginAutharization_MiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseRRD_LoginAutharization_Middleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<RRD_LoginAutharization_Middleware>();
    //    }
    //}
}
