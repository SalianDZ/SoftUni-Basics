using System;
namespace Week2SundayExercisе5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetForTheMovie = double.Parse(Console.ReadLine());
            int extraCount = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());
            double totalClothingPrice = clothingPrice * extraCount;

            double decorPrice = budgetForTheMovie * 0.10;

            if (extraCount > 150)
            {
                totalClothingPrice = totalClothingPrice - (totalClothingPrice * 0.10);
            }
            double notEnoughMoney = (totalClothingPrice + decorPrice) - budgetForTheMovie;
            double leftMoney = budgetForTheMovie - (totalClothingPrice + decorPrice);

            if ((decorPrice + totalClothingPrice) > budgetForTheMovie)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {notEnoughMoney:f2} leva more.");
            }
            else if (budgetForTheMovie >= (decorPrice + totalClothingPrice))
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:f2} leva left.");
            }
        }
    }
}