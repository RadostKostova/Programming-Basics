using System;

namespace _02_Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double priceTicket = 0;

            switch (projectType)
            {
                case "Premiere":
                    priceTicket = 12;
                    break;
                case "Normal":
                    priceTicket = 7.5;
                    break;
                case "Discount":
                    priceTicket = 5;
                    break;
            }

            double totalIncome = priceTicket * rows * cols;

            Console.WriteLine($"{totalIncome:f2} leva");
        }
    }
}
