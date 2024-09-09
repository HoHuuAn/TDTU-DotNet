namespace Exercise.Middlewares
{
    public class MyErrorHandler
    {
        private readonly RequestDelegate _next;

        public MyErrorHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }

            if (httpContext.Response.StatusCode == 405 || httpContext.Response.StatusCode == 404)
            {
                await HandleMethodNotSupportedAsync(httpContext);
            }

            if (httpContext.Response.StatusCode == 401)
            {
                await HandleUnauthorizedAsync(httpContext);
            }

            if (httpContext.Response.StatusCode == 403)
            {
                await HandleForbiddenAsync(httpContext);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            httpContext.Response.StatusCode = 500;
            httpContext.Response.ContentType = "application/json";

            var errorResponse = new
            {
                Message = "Internal Server Error",
                Reason = ex.Message
            };

            await httpContext.Response.WriteAsJsonAsync(errorResponse);
        }

        private static async Task HandleMethodNotSupportedAsync(HttpContext httpContext)
        {
            httpContext.Response.StatusCode = 405;
            httpContext.Response.ContentType = "application/json";

            var errorResponse = new
            {
                Message = "Method is not supported",
                HttpMethod = httpContext.Request.Method,
                RequestPath = httpContext.Request.Path
            };

            await httpContext.Response.WriteAsJsonAsync(errorResponse);
        }

        private static async Task HandleUnauthorizedAsync(HttpContext httpContext)
        {
            httpContext.Response.StatusCode = 401;
            httpContext.Response.ContentType = "application/json";

            var errorResponse = new
            {
                Message = "Please provide a JWT token in the Authorization header"
            };

            await httpContext.Response.WriteAsJsonAsync(errorResponse);
        }

        private async Task HandleForbiddenAsync(HttpContext httpContext)
        {
            httpContext.Response.StatusCode = 403;
            httpContext.Response.ContentType = "application/json";

            var errorResponse = new
            {
                Message = "Access forbidden"
            };

            await httpContext.Response.WriteAsJsonAsync(errorResponse);
        }
    }
}
