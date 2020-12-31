using System;

namespace _10_InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 0 || num >= 100 && num <= 200)
            {
                Console.WriteLine(); // should print nothing
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
