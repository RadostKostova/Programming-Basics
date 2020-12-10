using System;

namespace _06_CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int charityDays = int.Parse(Console.ReadLine());
            int chefs = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = cakes * 45;
            double wafflePrice = waffles * 5.80;
            double pancakePrice = pancakes * 3.20;

            double moneyPerDay = (cakePrice + wafflePrice + pancakePrice) * chefs;
            double totalMoney = moneyPerDay * charityDays;

            double totalProfit = totalMoney - (totalMoney * 0.125);
            Console.WriteLine(totalProfit);
        }
    }
}
