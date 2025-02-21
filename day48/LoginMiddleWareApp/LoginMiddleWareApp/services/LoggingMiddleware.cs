using System.Diagnostics;

namespace LoginMiddleWareApp.services
{
    public class LoggingMiddleware    {

        private  RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();

            // Log request details
            LogRequest(context);

            await _next(context); // Call next middleware

            stopwatch.Stop();

            // Log response details
            LogResponse(context, stopwatch.ElapsedMilliseconds);
        }

        private void LogRequest(HttpContext context)
        {
            var request = context.Request;
            var userAgent = request.Headers["User-Agent"].FirstOrDefault();
            var clientIp = context.Connection.RemoteIpAddress.ToString();

            Console.WriteLine($"Request at {DateTime.Now} - Method: {request.Method}, Path: {request.Path}, User Agent: {userAgent}, Client IP: {clientIp}");
        }

        private void LogResponse(HttpContext context, long elapsedMilliseconds)
        {
            var response = context.Response;
            var statusCode = response.StatusCode;

            Console.WriteLine($"Response at {DateTime.Now} - Status Code: {statusCode}, Elapsed Time: {elapsedMilliseconds} ms");
        }

    }
}
