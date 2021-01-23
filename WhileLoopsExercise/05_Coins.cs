using System;

namespace _05_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine()) * 100;
            double rest = 0;
            double coins = 0;

            while (money > 0)
            {
                // 2 lv
                rest = money % 200;
                coins += Math.Floor(money / 200);
                money = money - coins * 200;

                // 1 lv
                money = rest;
                rest = money % 100;
                coins += Math.Floor(money / 100);
                money = money - coins * 100;

                // 0.50 lv
                money = rest;
                rest = money % 50;
                coins += Math.Floor(money / 50);
                money = money - coins * 50;

                // 0.20 lv
                money = rest;
                rest = money % 20;
                coins += Math.Floor(money / 20);
                money = money - coins * 20;

                // 0.10 lv
                money = rest;
                rest = money % 10;
                coins += Math.Floor(money / 10);
                money = money - coins * 10;

                // 0.05 lv
                money = rest;
                rest = money % 5;
                coins += Math.Floor(money / 5);
                money = money - coins * 5;

                // 0.02 lv
                money = rest;
                rest = money % 2;
                coins += Math.Floor(money / 2);
                money = money - coins * 2;

                // 0.01 lv
                money = rest;
                rest = money % 1;
                coins += Math.Floor(money / 1);
                money = money - coins * 1;
            }

            Console.WriteLine(coins);
        }
    }
}
