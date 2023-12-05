using Microsoft.AspNetCore.Mvc.Filters;

namespace DecoratorDesignPattern.ActionFilter;

public class Log : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Log --------");
    }
    public override void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("-------- Log");
    }
}