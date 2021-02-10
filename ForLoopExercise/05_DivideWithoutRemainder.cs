using System;

namespace _05_DivideWithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                if (numb % 2 == 0)
                {
                    count++;
                    p1 = count * 1.00 / 10 * 100;
                }
                if (numb % 3 == 0)
                {
                    count++;
                    p2 = count * 1.00 / 10 * 100;
                }
                if (numb % 4 == 0)
                {
                    count++;
                    p3 = count * 1.00 / 10 * 100;
                }
            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
