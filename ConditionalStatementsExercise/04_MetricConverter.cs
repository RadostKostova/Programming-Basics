using System;

namespace _04_MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            switch (input)
            {
                case "m": number /= 1; break;
                case "mm": number /= 1000; break;
                case "cm": number /= 100; break;
                case "inch": number /= 39.37; break;
                default:
                    break;
            }

            switch (output)
            {
                case "m": number *= 1; break;
                case "mm": number *= 1000; break;
                case "cm": number *= 100; break;
                case "inch": number *= 39.37; break;
                default:
                    break;
            }

            Console.WriteLine($"{number:f3}");
        }
    }
}
