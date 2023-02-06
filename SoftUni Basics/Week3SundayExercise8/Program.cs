using System;
namespace Week3SundayExercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());    
            int arrivalHours = int.Parse(Console.ReadLine());   
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTotalMinutes = examHours * 60 + examMinutes;
            int arrivalTotalMinutes = arrivalHours * 60 + arrivalMinutes;

            if (arrivalTotalMinutes > examTotalMinutes)
            {
                Console.WriteLine("Late");
                int minutesDifference = arrivalTotalMinutes - examTotalMinutes;
                if (minutesDifference < 60)
                {
                    Console.WriteLine($"{minutesDifference} minutes after the start");
                }
                else
                {
                    int hours = minutesDifference / 60;
                    int minutes = minutesDifference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }
            else if (arrivalTotalMinutes < examTotalMinutes - 30)
            {
                Console.WriteLine("Early");
                int minutesDifference = examTotalMinutes - arrivalTotalMinutes;
                if (minutesDifference < 60)
                {
                    Console.WriteLine($"{minutesDifference} minutes before the start");
                }
                else
                {
                    int hours = minutesDifference / 60;
                    int minutes = minutesDifference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }
            else {
                Console.WriteLine("On time");
                int minutesDifference = examTotalMinutes - arrivalTotalMinutes;
                Console.WriteLine($"{minutesDifference} minutes before the start");
            }
        }
    }
}