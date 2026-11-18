    using Microsoft.AspNetCore.Diagnostics;

    namespace BookingApi.Exceptions
    {
        public class GlobalExceptionHandler : IExceptionHandler
        {
            public async ValueTask<bool> TryHandleAsync(
                HttpContext httpContext,
                Exception exception,
                CancellationToken cancellationToken)
            {
                switch (exception)
                {
                    case EmailInUseException:
                        httpContext.Response.StatusCode = 409;
                        break;
                    case FalsePassException:
                        httpContext.Response.StatusCode = 401;
                        break;
                    default:
                        return false;
                }
            
                await httpContext.Response.WriteAsJsonAsync(new { error = exception.Message }, cancellationToken);
                return true;
            
            }   
        }
    }