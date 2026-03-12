namespace UniMartAPI.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IWebHostEnvironment _env;
        public ExceptionMiddleware(RequestDelegate next,ILogger<ExceptionMiddleware> logger,IWebHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message); // this will log it - server side

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = 500; // internal server error

                var response = new
                {
                    StatusCode = 500,
                    Message = ex.Message,
                    StackTrace = _env.IsDevelopment() ? ex.StackTrace : "Production - Stack trace hidden" // only show stack trace in development
                };

                await context.Response.WriteAsJsonAsync(response);
            }
        }


    }
}
