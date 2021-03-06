﻿using System;

namespace _04_OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());

            int checkedBooks = 0;
            string currentBookName = "";
            string result = string.Empty;

            while (true)
            {
                currentBookName = Console.ReadLine();

                if (bookName == currentBookName)
                {
                    result = $"You checked {checkedBooks} books and found it.";
                    break;
                }
                checkedBooks++;

                if (checkedBooks == libraryCapacity)
                {
                    result = "The book you search is not here!" + Environment.NewLine + $"You checked {checkedBooks} books.";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
