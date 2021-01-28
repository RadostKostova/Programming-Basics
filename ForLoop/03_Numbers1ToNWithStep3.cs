using System;

namespace _03_Numbers1ToNWithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
