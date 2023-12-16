using AdvanceAPI.CORE.Utilities;
using AdvanceAPI.ExceptionHandling.Base;
using AdvanceAPI.ExceptionHandling.Employee;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace AdvanceAPI.API.Extensions
{
    public static class ExceptionMiddlewareExtension
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                    if (contextFeature is not null)
                    {
                        context.Response.StatusCode = contextFeature.Error switch
                        {
                            NotFoundException => StatusCodes.Status404NotFound,

                            _ => StatusCodes.Status500InternalServerError
                        };

                        // log alınabilir

                        var response = JsonSerializer.Serialize(Result<string>.Fail(contextFeature.Error.Message));
                        
                        await context.Response.WriteAsync(response);
                    }
                });
            });
        }
    }
}
