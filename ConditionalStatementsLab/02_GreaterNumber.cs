﻿using System;

namespace _02_GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1);
            }
            else
            {
                Console.WriteLine(n2);
            }
        }
    }
}
