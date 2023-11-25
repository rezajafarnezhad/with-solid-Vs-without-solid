

namespace SRP__.Ticket_System_Without_SRP;

public class TicketWithoutSRP
{

    public static void AddTicket()
    {
        Console.WriteLine("Ticket Added ...");
    }

    public static void DeleteTicket()
    {
        Console.WriteLine("Ticket Deleted ...");
    }

    public static void SendSms()
    {
        Console.WriteLine("Sms Sent ...");
    }

    public static void LogInformation()
    {
        Console.WriteLine("Information Logged in ...");
    }
    public static void LogInformation(string logMessage)
    {
        Console.WriteLine(logMessage);
    }

}