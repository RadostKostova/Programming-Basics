using System;

namespace _05_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallPrice = int.Parse(Console.ReadLine());

            double cakePrice = hallPrice * 0.2;
            double drinksPrice = cakePrice - cakePrice * 0.45;
            double animator = hallPrice / 3;

            double totalPrice = hallPrice + cakePrice + drinksPrice + animator;
            Console.WriteLine(totalPrice);
        }
    }
}
