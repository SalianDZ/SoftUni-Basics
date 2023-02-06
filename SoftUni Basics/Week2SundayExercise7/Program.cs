using System;
namespace Week2SundayExercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int cpuS = int.Parse(Console.ReadLine());
            int ramMemory = int.Parse(Console.ReadLine());

            double videoCardsSum = videoCards * 250.0;
            double cpuSum = (videoCardsSum * 0.35) * cpuS;
            double ramMemorySum = (videoCardsSum * 0.10) * ramMemory;

            double sum = videoCardsSum + cpuSum + ramMemorySum;

            if (videoCards > cpuS)
            {
                sum = sum - (sum * 0.15);
                Console.WriteLine(sum);
            }

            double leftMoney = budget - sum;
            double requidredMoney = sum - budget;

            if (sum <= budget) {
                Console.WriteLine($"You have {leftMoney:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {requidredMoney:f2} leva more!");
            }
        }
    }
}