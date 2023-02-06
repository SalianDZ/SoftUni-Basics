using System;

namespace Week1SundayExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input 
            int numberPagesInBook = int.Parse(Console.ReadLine());
            int numberPagesPerHour = int.Parse(Console.ReadLine());
            int daysNumber = int.Parse(Console.ReadLine());

            //Calculations
            int timeForABook = numberPagesInBook / numberPagesPerHour;
            int hoursPerDayForABook = timeForABook / daysNumber;

            //Output
            Console.WriteLine(hoursPerDayForABook);
        }
    }
}