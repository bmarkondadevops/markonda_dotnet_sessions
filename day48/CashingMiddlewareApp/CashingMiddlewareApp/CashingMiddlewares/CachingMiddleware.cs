using System.Collections.Concurrent;

namespace CashingMiddlewareApp.CashingMiddlewares
{
    public class CachingMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ConcurrentDictionary<string, string> _cache;

        public CachingMiddleware(RequestDelegate next)
        {
            _next = next;
            _cache = new ConcurrentDictionary<string, string>();
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.HasValue && _cache.TryGetValue(context.Request.Path, out string cachedResponse))
            {
                context.Response.StatusCode = 200; // OK
                await context.Response.WriteAsync(cachedResponse);
                return; // Short circuit here
            }

            var originalBodyStream = context.Response.Body;
            using var responseBodyStream = new MemoryStream();
            context.Response.Body = responseBodyStream;

            await _next(context);

            responseBodyStream.Seek(0, SeekOrigin.Begin);
            var responseContent = await new StreamReader(responseBodyStream).ReadToEndAsync();
            responseBodyStream.Seek(0, SeekOrigin.Begin);

            await responseBodyStream.CopyToAsync(originalBodyStream);

            // Cache the response for future requests
            if (context.Response.StatusCode == 200)
            {
                _cache.TryAdd(context.Request.Path, responseContent);
            }
        }

    }
}
