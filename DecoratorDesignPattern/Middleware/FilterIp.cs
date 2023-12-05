using System.Net;
using System.Net.Mail;
using DecoratorDesignPattern.CoreL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DecoratorDesignPattern.Middleware;

public static class FilterIp
{
    public static IApplicationBuilder UseFilterIp(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<FilterIpIran>();
    }
}
public class FilterIpIran
{
    private readonly RequestDelegate _next;

    public FilterIpIran(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        var ip = context?.Connection?.RemoteIpAddress?.ToString();
        var userIp = ip;
        if (userIp == "127.0.0.1")
        {
            var result = new ApiResponse(false, "Ip آدرس شما فیلتر می باشد", ApiStatusCode.ServerError);
            var json = JsonConvert.SerializeObject(result);
            context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(json);
        }
        else
        {
            await _next(context);
        }


    }

}