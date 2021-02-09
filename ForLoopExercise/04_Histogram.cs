using System;

namespace _04_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1numbers = 0;
            double p2numbers = 0;
            double p3numbers = 0;
            double p4numbers = 0;
            double p5numbers = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1numbers++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2numbers++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3numbers++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4numbers++;
                }
                else if (num >= 800)
                {
                    p5numbers++;
                }
            }

            double p1 = (p1numbers / n) * 100.0;
            double p2 = (p2numbers / n) * 100.0;
            double p3 = (p3numbers / n) * 100.0;
            double p4 = (p4numbers / n) * 100.0;
            double p5 = (p5numbers / n) * 100.0;

            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
