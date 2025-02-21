using System.Threading.Tasks;
using DIWebApplication.services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DIWebApplication.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RddLogAndEmailingMiddleWare
    {
        private readonly RequestDelegate _next;

        public RddLogAndEmailingMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IRRDEmailService irrdEmailService)
        {

           ///pre processing
            Console.WriteLine("pre loggin check");
            await irrdEmailService.SendEMailAsync("admin@rrd", "from middleware", "Middle email called succesfully");
            await _next(httpContext);
            Console.WriteLine("post  loggin check");
            //post processing
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class RddLogAndEmailingMiddleWare
    //{
    //    public static IApplicationBuilder UseRRDMidleWare(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<RRDMidleWare>();
    //    }
    //}
}
