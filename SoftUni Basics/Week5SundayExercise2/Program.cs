using System;
namespace Week5SundayExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            double sum = 0;
            int badGradesCounter = 0;
            int problemCounter = 0;
            string lastProblem = "";
            double avg = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Enough")
                {
                    //НУЖНИТЕ НЕЩА
                    Console.WriteLine($"Average score: {avg:f2}");
                    Console.WriteLine($"Number of problems: {problemCounter}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGradesCounter++;
                }
                if (badGradesCounter == badGrades)
                {
                    Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                    break;
                }

                sum += grade;
                problemCounter++;
                lastProblem = command;
                avg = sum / problemCounter;
                continue;
            }
        }
    }
}