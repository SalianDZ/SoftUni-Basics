using System;
namespace Week3SaturdayExercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 100 && num <= 200 || num == 0)
            { }
            else if (num < 100 || num > 200 || num != 0)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}