namespace ShortCircuitingMiddlewareApp.Middlewares
{
    public class AuthenticationMiddleware
    {
        private  RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.User.Identity.IsAuthenticated)
            {
                context.Response.StatusCode = 401; // Unauthorized
                await context.Response.WriteAsync("You are not authenticated.");
                return; // Short circuiting here
            }

            await _next(context); // Continue with next middleware if authenticated
        }

    }
}
