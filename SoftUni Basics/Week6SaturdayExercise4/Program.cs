using System;
namespace Week6SaturdayExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int magicalnumber = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            bool isValid = false;

            for (int leftNumber = intervalStart; leftNumber <= intervalEnd; leftNumber++)
            {
                for (int rightNumber = intervalStart; rightNumber <= intervalEnd; rightNumber++)
                {
                    combinationCounter++;
                    int sum = leftNumber + rightNumber;
                    if (sum == magicalnumber)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({leftNumber} + {rightNumber} = {sum})");
                        isValid = true;
                        break;
                    }
                }
                if (isValid == true)
                {
                    break;
                }
                
            }
            if (isValid == false)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicalnumber}");
            }
        }
    }
}