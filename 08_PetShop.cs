using System;

namespace _08_PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int animalsCount = int.Parse(Console.ReadLine());

            double foodPriceForDogs = dogsCount * 2.50;
            double foodPriceForAnimals = animalsCount * 4;

            double totalSum = foodPriceForDogs + foodPriceForAnimals;

            Console.WriteLine($"{totalSum:f1} lv.");
        }
    }
}
