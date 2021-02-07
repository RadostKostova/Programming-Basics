using System;

namespace _02_HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int big = int.Parse(Console.ReadLine());
            int sum = big;

            for (var i = 2; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;

                if (a > big)
                {
                    big = a;
                }
            }

            if (big == (sum - big))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum  = " + big);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(big - (sum - big)));
            }
        }
    }
}
