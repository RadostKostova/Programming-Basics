using System;

namespace _01_PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine()); //rectangle parameters
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            int x = int.Parse(Console.ReadLine());  //point parameters
            int y = int.Parse(Console.ReadLine());

            if ((x > x1 && x < x2 && y > y1 && y < y2) || ((x < x1 || y < y1 || x > x2 || y > y2)))
            {
                Console.WriteLine("Inside / Outside");
            }
            else
            {
                Console.WriteLine("Border");
            }
        }
    }
}
