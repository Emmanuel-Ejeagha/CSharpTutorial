using System;

class Program
{
    static void Main()

    {
        int? TicketsOnSale = null;
        int AvailableTickets = TicketsOnSale ?? 0;
        Console.WriteLine("Available Tickets = {0}", AvailableTickets);
    }
    

}