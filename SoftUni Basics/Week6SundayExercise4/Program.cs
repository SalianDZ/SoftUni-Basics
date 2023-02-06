using System;
namespace Week6SundayExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            int problemCounter = 0;
            double gradesSum = 0;
            double currentGradeSum = 0;
            int gradesCounter = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Finish")
                {
                    break;
                }

                currentGradeSum = 0;
                problemCounter++;

                for (int grades = 0; grades < jury; grades++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    currentGradeSum += currentGrade;
                    gradesSum += currentGrade;
                    gradesCounter++;
                }
                Console.WriteLine($"{command} - {(currentGradeSum / jury):f2}.");
            }
            Console.WriteLine($"Student's final assessment is {(gradesSum / gradesCounter):f2}.");
        }
    }
}