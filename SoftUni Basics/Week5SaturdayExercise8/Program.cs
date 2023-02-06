using System;
namespace Week5SaturdayExercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentGrade = 1;
            int excludeCounter = 0;
            double sum = 0;

            while (currentGrade <= 12)
            {
                double assessment = double.Parse(Console.ReadLine());
                sum += assessment;
                currentGrade++;
                if (assessment < 4)
                {
                    excludeCounter++;
                }
                if (excludeCounter == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {currentGrade - 2} grade");
                    break;
                }
            }
            if (excludeCounter != 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
            }
        }
    }
} 