using System;

namespace Week5SundayExercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int sum = 0;

            int sumCubicMeters = width * lenght * height;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    Console.WriteLine($"{sumCubicMeters - sum} Cubic meters left.");
                    break;
                }
                else
                {
                    int commandInNumbers = int.Parse(command);
                    sum+= commandInNumbers;
                    if (sum >= sumCubicMeters)
                    {
                        Console.WriteLine($"No more free space! You need {sum - sumCubicMeters} Cubic meters more.");
                        break;
                    }
                }
            }
        }
    }
}