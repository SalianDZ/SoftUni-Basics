using System;
using System.Diagnostics.CodeAnalysis;

namespace Week3SundayExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 
            int fishersCount = int.Parse(Console.ReadLine());
            double sum = 0;
            double shipPrice = 0;

            switch (season)
            {
                case "Spring":
                    if (fishersCount <= 6) {
                        shipPrice = 3000;
                        sum = shipPrice - (shipPrice * 0.10);
                    }
                    else if (fishersCount >= 7 && fishersCount <= 11) {
                        shipPrice = 3000;
                        sum = shipPrice - (shipPrice * 0.15);
                    }
                    else if (fishersCount >= 12) {
                        shipPrice = 3000;
                        sum = shipPrice - (shipPrice * 0.25);
                    }
                    break;
                case "Winter":
                    if (fishersCount <= 6)
                    {
                        shipPrice = 2600;
                        sum = shipPrice - (shipPrice * 0.10);
                    }
                    else if (fishersCount >= 7 && fishersCount <= 11)
                    {
                        shipPrice = 2600;
                        sum = shipPrice - (shipPrice * 0.15);
                    }
                    else if (fishersCount >= 12)
                    {
                        shipPrice = 2600;
                        sum = shipPrice - (shipPrice * 0.25);
                    }
                    break;
                case "Summer":
                case "Autumn":
                    if (fishersCount <= 6)
                    {
                        shipPrice = 4200;
                        sum = shipPrice - (shipPrice * 0.10);
                    }
                    else if (fishersCount >= 7 && fishersCount <= 11)
                    {
                        shipPrice = 4200;
                        sum = shipPrice - (shipPrice * 0.15);
                    }
                    else if (fishersCount >= 12)
                    {
                        shipPrice = 4200;
                        sum = shipPrice - (shipPrice * 0.25);
                    }
                    break;


            }
                if (fishersCount % 2 == 0 && season != "Autumn") {
                    sum = sum - (sum * 0.05);
                }

                if (budget >= sum)
                {
                    Console.WriteLine($"Yes! You have {budget - sum:f2} leva left.");
                }
                else {
                    Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva.");
                }
        }
    }
}