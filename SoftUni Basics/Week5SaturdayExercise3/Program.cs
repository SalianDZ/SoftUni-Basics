using System;
namespace Week5SaturdayExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            int currentUserNumber = 0;
            int sum = 0;

            while (sum < userNumber)
            {
                currentUserNumber = int.Parse(Console.ReadLine());
                sum += currentUserNumber;
            }
            Console.WriteLine(sum);
        }
    }
}