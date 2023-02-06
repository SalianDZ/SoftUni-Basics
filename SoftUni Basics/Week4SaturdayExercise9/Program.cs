using System;
namespace Week4SaturdayExercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;
            for (int i = 1; i <= pairsCount; i++)
            {
                int firstnum = int.Parse(Console.ReadLine());

                leftsum += firstnum;

            }
            for (int x = 1; x <= pairsCount; x++)
            {
                int secondnum = int.Parse(Console.ReadLine());
                rightsum += secondnum;
            }

            if (leftsum == rightsum)
            {
                Console.WriteLine($"Yes, sum = {leftsum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftsum - rightsum)}");
            }
        }
    }
}