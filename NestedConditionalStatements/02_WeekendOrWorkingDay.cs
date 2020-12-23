using System;

namespace _02_WeekendOrWorkingDay
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "Monday":
                case "Thuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weedend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
