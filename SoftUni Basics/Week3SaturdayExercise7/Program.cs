using System;
namespace Week3SaturdayExercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            if (weekDay == "Monday" || weekDay == "Tuesday" || weekDay == "Wednesday" || weekDay == "Thursday" || weekDay == "Friday" || weekDay == "Saturday")
            {
                if (hour == 10 || hour == 11 || hour == 12 || hour == 13 || hour == 14 || hour == 15 || hour == 16 || hour == 17 || hour == 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else {
                Console.WriteLine("closed");
            }
        }
    }
}