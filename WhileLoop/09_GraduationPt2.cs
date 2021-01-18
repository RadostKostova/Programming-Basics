using System;

namespace _09_GraduationPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double sum = 0;
            int poorGrades = 0;

            while (grade <= 12)
            {
                double grades = double.Parse(Console.ReadLine());

                if (grades >= 4)
                {
                    sum += grades;
                    grades++;
                }
                else
                {
                    poorGrades += 1;
                }

                if (poorGrades > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {grades} grade"); break;
                }
            }
            if (poorGrades < 2)
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
        }
    }
}
