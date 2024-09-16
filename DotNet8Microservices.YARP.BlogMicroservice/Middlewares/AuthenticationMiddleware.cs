namespace DotNet8Microservices.YARP.BlogMicroservice.Middlewares
{
    public class AuthenticationMiddleware
    {
        private readonly ILogger<AuthenticationMiddleware> _logger;
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(ILogger<AuthenticationMiddleware> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
        }
    }
}
