using Microsoft.AspNetCore.Diagnostics;
using NCQ.Todo.App.Application.Common.Exceptions;
using System.Net;
using System.Text.Json;

namespace NCQ.Todo.App.Api.Extensions
{
    public static class ErrorHandlerExtensions
    {
        public static void UseErrorHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature == null) return;

                    context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                    context.Response.ContentType = "application/json";

                    context.Response.StatusCode = contextFeature.Error switch
                    {
                        BadRequestException => (int)HttpStatusCode.BadRequest,
                        OperationCanceledException => (int)HttpStatusCode.ServiceUnavailable,
                        NotFoundException => (int)HttpStatusCode.NotFound,
                        _ => (int)HttpStatusCode.InternalServerError
                    };

                    object errorResponse = new
                    {
                        statusCode = context.Response.StatusCode,
                        message = contextFeature.Error.GetBaseException().Message
                    };

                    if (contextFeature.Error is BadRequestException)
                    {
                        var exception = (BadRequestException)contextFeature.Error;
                        if (exception.Errors.Length > 0)
                        {
                            errorResponse = new
                            {
                                statusCode = context.Response.StatusCode,
                                message = contextFeature.Error.GetBaseException().Message,
                                errors = exception.Errors
                            };
                        }
                    }

                    await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));
                });
            });
        }
    }

}
