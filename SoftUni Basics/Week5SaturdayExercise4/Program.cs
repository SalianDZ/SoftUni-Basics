using System;
namespace Week5SaturdayExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            int k = 1;

            while (k <= userNumber)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}