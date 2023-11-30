using Metalama.Framework.Aspects;


namespace AOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var result = Sum(12,12);
            

        }

        [LogAttribute]
        public static int Sum(int a, int b)
        {
            return a+b;
        }
    }
}


public class LogAttribute : OverrideMethodAspect
{
    public override dynamic? OverrideMethod()
    {
        Console.WriteLine($"{meta.Target.Method} started.");

        try
        {
            var result = meta.Proceed();
            Console.WriteLine($"{meta.Target.Method} succeeded.");
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine($"{meta.Target.Method} failed: {e.Message}.");

            throw;
        }
    }

  
}