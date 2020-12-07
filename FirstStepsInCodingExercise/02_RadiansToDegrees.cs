using System;

namespace _02_RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double result = radians * (180 / Math.PI);

            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
