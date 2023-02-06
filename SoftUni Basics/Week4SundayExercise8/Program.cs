using System;
namespace Week4SundayExercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            double pointsSum = 0.0;
            int timesWonW = 0;
            int timesWonF = 0;
            int timesWonSF = 0;

            for (int i = 1; i <= tournamentsCount; i++) { 
                string tournamentStage = Console.ReadLine();

                switch (tournamentStage)
                {
                    case "W":
                        startingPoints += 2000;
                        timesWonW++;
                        break;
                    case "F":
                        startingPoints += 1200;
                        timesWonF++;
                        break;
                    case "SF":
                        startingPoints += 720;
                        timesWonSF++;
                        break;
                }

            }
            Console.WriteLine($"Final points: {startingPoints}");
            double averagePoints = ((timesWonW * 2000) + (timesWonF * 1200) + (timesWonSF * 720)) / tournamentsCount;
            Console.WriteLine($"Average points: {averagePoints}");
            double percetage = ((timesWonW * 1.0) / tournamentsCount) * 100;
            Console.WriteLine($"{percetage:f2}%");
        }
    }
}