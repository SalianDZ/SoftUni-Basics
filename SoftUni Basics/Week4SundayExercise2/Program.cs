using System;
namespace Week4SundayExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= numbersCount; i++) { 
                int userNumber = int.Parse(Console.ReadLine());
                sum = sum + userNumber;

                if (userNumber > maxNumber) { 
                    maxNumber = userNumber; 
                }

            }
            int sumWithoutMaxNumber = sum - maxNumber;
            if (maxNumber == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sumWithoutMaxNumber)}");
            }

        }
    }
}