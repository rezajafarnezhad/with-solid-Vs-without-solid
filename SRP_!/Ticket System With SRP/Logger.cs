namespace SRP__.Ticket_System_With_SRP;

public class Logger
{
    public static void LogInformation()
    {
        Console.WriteLine("Information Logged in ...");
    }
    public static void LogInformation(string logMessage)
    {
        Console.WriteLine(logMessage);
    }
}