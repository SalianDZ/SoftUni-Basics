using System;
namespace Week3SaturdayExercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            double ticketPrice = 0;

            switch (dayOfWeek)
            {
                case "Monday": ticketPrice = 12; break;
                case "Tuesday": ticketPrice = 12; break;
                case "Friday": ticketPrice = 12; break;
                case "Wednesday": ticketPrice = 14; break;
                case "Thursday": ticketPrice = 14; break;
                case "Saturday": ticketPrice = 16; break;
                case "Sunday": ticketPrice = 16; break;
            }
            Console.WriteLine(ticketPrice);
        }
    }
}