using SRP__.Ticket_System_With_SRP;
using SRP__.Ticket_System_Without_SRP;

namespace SRP__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-System Ticket-");
            TicketWithoutSRP.AddTicket();
            TicketWithoutSRP.SendSms();
            TicketWithoutSRP.LogInformation();
            TicketWithoutSRP.DeleteTicket();
            TicketWithoutSRP.SendSms();
            TicketWithoutSRP.LogInformation("Log Deleted Ticket");

            Console.WriteLine("-SRP-");
            TicketWithSRP.AddTicket();
            TicketWithSRP.DeleteTicket();
        }
    }
}
