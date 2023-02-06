using System;
namespace Week2SundayExercisе6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());  
            double distanceInMetres = double.Parse(Console.ReadLine()); 
            double timeInSecondsForOneMetre = double.Parse(Console.ReadLine());

            double distanceInSeconds = distanceInMetres * timeInSecondsForOneMetre;
            double slowedDownCount = Math.Floor(distanceInMetres / 15) * 12.5;
            double totalTime = distanceInSeconds + slowedDownCount;


            double leftSeconds = totalTime - recordInSeconds;

            if (recordInSeconds <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {leftSeconds:f2} seconds slower.");
            }
            else if (recordInSeconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}