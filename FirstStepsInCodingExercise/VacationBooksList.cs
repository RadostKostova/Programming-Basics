using System;

namespace _04_VacantionBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesReadPErHour = double.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());

            double totalHours = pages / pagesReadPErHour;
            double hoursPerDay = totalHours / daysToRead;

            Console.WriteLine($"{hoursPerDay:f1}");

        }
    }
}
