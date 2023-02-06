using System;
namespace Week2SundayExercisе4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            int totalQuantity = puzzleCount + dollCount + bearCount + minionCount + truckCount;
            double totalSum = (puzzleCount * 2.60) + (dollCount * 3.0) + (bearCount * 4.10) +
                (minionCount * 8.20) + (truckCount * 2.0);
            double budget = totalSum;

            if (totalQuantity >= 50)
            {
                budget = budget - (budget * 0.25); 
            }
            budget = budget - (budget * 0.10);
            double enoughMoney = budget - tripCost;
            double notEnoughMoney = tripCost - budget;

            if (budget >= tripCost)
            {
                Console.WriteLine($"Yes! {enoughMoney:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {notEnoughMoney:f2} lv needed.");
            }
        }
    }
}