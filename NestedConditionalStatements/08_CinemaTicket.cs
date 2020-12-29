using System;

namespace _08_CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int ticketPrice = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                    ticketPrice = 12;
                    Console.WriteLine(ticketPrice);
                    break;
                case "Tuesday":
                    ticketPrice = 12;
                    Console.WriteLine(ticketPrice);
                    break;
                case "Wednesday":
                    ticketPrice = 14;
                    Console.WriteLine(ticketPrice);
                    break;
                case "Thursday":
                    ticketPrice = 14;
                    Console.WriteLine(ticketPrice);
                    break;
                case "Friday":
                    ticketPrice = 12;
                    Console.WriteLine(ticketPrice);
                    break;
                case "Saturday":
                    ticketPrice = 16;
                    Console.WriteLine(ticketPrice);
                    break;
                case "Sunday":
                    ticketPrice = 16;
                    Console.WriteLine(ticketPrice);
                    break;
            }
        }
    }
}
