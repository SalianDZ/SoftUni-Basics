using System;
namespace Week4SaturdayExercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxNumber) {
                    maxNumber = currentNumber;
                }
                if (currentNumber < minNumber) {
                    minNumber = currentNumber;
                }
                 
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}