using System;
namespace Week6SaturdayExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    Console.WriteLine($"{hour}:{min:d2}");
                }
            }
        }
    }
}