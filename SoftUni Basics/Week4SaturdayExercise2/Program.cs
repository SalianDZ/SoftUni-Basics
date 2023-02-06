using System;
namespace Week4SaturdayExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userNumber = int.Parse(Console.ReadLine());
            for (int i = userNumber; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}