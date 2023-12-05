using DecoratorDesignPattern.CoreL;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net;

namespace DecoratorDesignPattern.Middleware;

public static class ApiCustomExceptionHandlerMiddlewareExtensions
{
    public static IApplicationBuilder UseApiCustomExceptionHandler(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ApiCustomExceptionHandlerMiddleware>();
    }
}

public class ApiCustomExceptionHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ApiCustomExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        string message = null;
        HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;
        ApiStatusCode apiStatusCode = ApiStatusCode.ServerError;

        try
        {
            await _next(context);
        }
        catch (ArgumentNullException e)
        {
            httpStatusCode = HttpStatusCode.BadRequest;
            SetErrorMessage(e);
            await WriteToResponseAsync();
        }

        void SetErrorMessage(Exception exception)
        {
            message = exception.Message;
        }

        async Task WriteToResponseAsync()
        {
            if (context.Response.HasStarted)
                throw new InvalidOperationException("The response has already started, the http status code middleware will not be executed.");

            var result = new ApiResponse(false, message, apiStatusCode);
            var json = JsonConvert.SerializeObject(result);

            context.Response.StatusCode = (int)httpStatusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(json);
        }
    }

}