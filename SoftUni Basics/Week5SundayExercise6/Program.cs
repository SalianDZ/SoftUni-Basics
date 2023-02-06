using System;
namespace Week5SundayExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int sum = 0;

            int cakeBlocks = lenght * width;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                {
                    Console.WriteLine($"{cakeBlocks - sum} pieces are left.");
                    break;
                }
                else
                {
                    int currentNumber = int.Parse(command);
                    sum += currentNumber;
                    if (sum >= cakeBlocks)
                    {
                        Console.WriteLine($"No more cake left! You need {sum - cakeBlocks} pieces more.");
                        break;
                    }
                }
            }
        }
    }
}