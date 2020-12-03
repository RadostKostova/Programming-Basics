using System;

namespace _09_YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;

            double totalPrice = squareMeters * pricePerSquareMeter;
            double discount = totalPrice * 0.18;

            Console.WriteLine($"The final price is: {totalPrice - discount:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
