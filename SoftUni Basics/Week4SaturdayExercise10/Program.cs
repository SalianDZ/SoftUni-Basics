using System;
using System.Diagnostics.CodeAnalysis;

namespace Week4SaturdayExercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEvenNumbers += number;
                }
                else
                {
                    sumOddNumbers += number;
                }
            }
            if (sumEvenNumbers == sumOddNumbers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumOddNumbers}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumEvenNumbers - sumOddNumbers)}");
            }
        }
    }
}