using System;

namespace _03_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = 0;
            int min = 0;

            while (input != "END")
            {
                int n = int.Parse(input);

                if (n > max)
                {
                    max = n;
                }

                if (n < min)
                {
                    min = n;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
