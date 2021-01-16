using System;

namespace _07_MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            for (int i = 1; i <= numbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > minNumber)
                {
                    minNumber = currentNumber;
                }
            }

            Console.WriteLine(minNumber);
        }
    }
}
