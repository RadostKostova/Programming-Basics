using System;

namespace _06_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < openedTabs; i++)
            {
                string websiteName = Console.ReadLine();

                if (websiteName == "Facebook")
                {
                    salary -= 150;

                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        return;
                    }
                }
                else if (websiteName == "Instagram")
                {
                    salary -= 100;

                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        return;
                    }
                }
                else if (websiteName == "Reddit")
                {
                    salary -= 50;

                    if (salary <= 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        return;
                    }
                }
            }
            Console.WriteLine(salary);
        }
    }
}
