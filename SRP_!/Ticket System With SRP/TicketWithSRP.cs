namespace SRP__.Ticket_System_With_SRP;

public class TicketWithSRP
{
    public static void AddTicket()
    {
        Console.WriteLine("Ticket Added ...");
        SendSms.SendSmsSRP();
        Logger.LogInformation();
    }

    public static void DeleteTicket()
    {
        Console.WriteLine("Ticket Deleted ...");
        SendSms.SendSmsSRP();
        Logger.LogInformation("Log Deleted Ticket");
    }
}