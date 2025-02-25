using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using ServicesAndDIApp.Services;
using System.Threading.Tasks;

namespace ServicesAndDIApp.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RrdAuditionMiddleWare
    {
        private readonly RequestDelegate _next;

        public RrdAuditionMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext,IRRDBlobService blobServcie)
        {
            blobServcie.Log("","","IAM an AUITOR MIDDLEWARE,I LISTEN TO ALL REQUEST");

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RrdAuditionMiddleWareExtensions
    {
        public static IApplicationBuilder UseRrdAuditionMiddleWare(this WebApplication builder)
        {
            return builder.UseMiddleware<RrdAuditionMiddleWare>();
        }
    }
}
