using LoginMiddlewareExcerciseClassOriented.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace LoginMiddlewareExcerciseClassOriented.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RRD_LoginAuthentication_Middleware
    {
        private readonly RequestDelegate _next;

        public RRD_LoginAuthentication_Middleware(RequestDelegate next)
        {
            Console.WriteLine("Login Authentication Initiated ");
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,IRRDLoginService rRDLoginService)
        {
            Console.WriteLine("Pre Authentication Process Started");
            string userName = "Sachin";
            bool result= rRDLoginService.LoginAuthenticationAsync(userName);
            if(!result) 
            {
                Console.WriteLine("Short Circuited: User Not Found.");
            }
            else {

                Console.WriteLine("User Present in Database");
                await _next(httpContext);
                Console.WriteLine("Post Authentication Check");
            }
                
          
           
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class RRD_Login_MiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseRRD_Login_Middleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<RRD_Login_Middleware>();
    //    }
    //}
}
