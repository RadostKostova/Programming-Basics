﻿using System;

namespace _07_FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
			double strawberriesPrice = double.Parse(Console.ReadLine());
			double bananasquantity = double.Parse(Console.ReadLine());
			double orangesquantity = double.Parse(Console.ReadLine());
			double raspberriesquantity = double.Parse(Console.ReadLine());
			double strawberriesquantity = double.Parse(Console.ReadLine());
			
			double raspberriesPrice = strawberriesPrice / 2;
			double orangesPrice = raspberriesPrice - 0.4 * raspberriesPrice;
			double bananasPrice = raspberriesPrice - 0.8 * raspberriesPrice;

			double bananasSum = bananasquantity * bananasPrice;
			double orangesSum = orangesquantity * orangesPrice;
			double raspberriesSum = raspberriesquantity * raspberriesPrice;
			double strawberriesSum = strawberriesquantity * strawberriesPrice;

			double totalSum = (raspberriesSum + orangesSum + bananasSum + strawberriesSum);
			Console.WriteLine(Math.Round(totalSum, 2));
		}
    }
}
