using System;
namespace Week4SaturdayExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int power = 0; power <= n; power+=2)
            {
                Console.WriteLine(Math.Pow(2, power));
            }
        }
    }
}