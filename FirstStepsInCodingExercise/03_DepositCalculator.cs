using System;

namespace _03_DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double interest = deposit * percent;
            double interest1 = interest / 12;
            double sum = deposit + (3 * (months) * interest1);

            Console.WriteLine($"{sum:f2}");
        }
    }
}
