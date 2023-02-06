using System;
namespace Week4SundayExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int reviewersCount = int.Parse(Console.ReadLine());
            double newPoints = 0;
            double sum = 0;

            for (int i = 1; i <= reviewersCount; i++)
            {
                string reviewerName = Console.ReadLine();
                double additionalPoints = double.Parse(Console.ReadLine());
                newPoints = (reviewerName.Length * additionalPoints) / 2;

                startingPoints += newPoints; 
                if (startingPoints > 1250.5)
                {
                    break;
                }
            }

            if (startingPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {startingPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - startingPoints:f1} more!");
            }

        }
    }
}