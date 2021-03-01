using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberJury = int.Parse(Console.ReadLine());

            double sum = 0;
            double allSum = 0;
            double averageSum = 0;
            int counter = 0;
            string namePresentation = "";

            while (true)
            {
                namePresentation = Console.ReadLine();

                if (namePresentation == "Finish")
                {
                    break;
                }

                for (int i = 1; i <= numberJury; i++)
                {
                    double evaluation = double.Parse(Console.ReadLine());
                    sum += evaluation;
                    allSum = sum / numberJury;
                    counter++;
                }

                Console.WriteLine($"{namePresentation} - {allSum:f2}.");
                averageSum += sum;                    
                sum = 0;                            
            }
            averageSum /= counter;                    
            Console.WriteLine($"Student's final assessment is {averageSum:f2}.");
        }
    }
}
