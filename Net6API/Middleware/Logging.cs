using Net6API.LoggingData;

namespace Net6API.Middleware
{
    public class Logging
	{
        private readonly RequestDelegate requestDelegate;
        public Logging(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }
        public async Task InvokeAsync(HttpContext context, LogDbContext loggerContext)
        {
            try
            {
                await requestDelegate(context);
            }
            catch (Exception ex)
            {
                var errorLog = new LogError()
                {
                    ErrorDetails = ex.ToString(),
                    LogDate = DateTime.Now
                };
                await loggerContext.LogError.AddAsync(errorLog);
                await loggerContext.SaveChangesAsync();
            }
        }
    }

    public static class MiddlewareRegistrationExtension
    {
        public static void UseAppException(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<Logging>();
        }
    }
}