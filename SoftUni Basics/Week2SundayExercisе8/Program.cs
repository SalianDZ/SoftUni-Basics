using System;
namespace Week2SundayExercisе8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());    
            int restDuration = int.Parse(Console.ReadLine());

            double lunchTime = restDuration / 8.0;
            double relaxTime = restDuration / 4.0;

            double leftTimeOfRest = restDuration - lunchTime - relaxTime;

            

            if (episodeDuration > leftTimeOfRest)
            {
                double neccesaryTime = Math.Ceiling(episodeDuration - leftTimeOfRest);
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {neccesaryTime} more minutes.");
            }

            else if (leftTimeOfRest >= episodeDuration)
            {
                double leftTime = Math.Ceiling(leftTimeOfRest - episodeDuration);
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {leftTime} minutes free time.");
            }
        }
    }
}