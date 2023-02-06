using System;
namespace Week3SundayExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";
            double priceForSleeping = 0;
            string destination;

            if (budget <= 100) {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        place = "Camp";
                        priceForSleeping = budget - (budget * 0.30);
                        break;
                    case "winter":
                        place = "Hotel";
                        priceForSleeping = budget - (budget * 0.70);
                        break;
                }
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{place} - {budget - priceForSleeping:f2}");
            }
            else if (budget <= 1000) {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        place = "Camp";
                        priceForSleeping = budget - (budget * 0.40);
                        break;
                    case "winter":
                        place = "Hotel";
                        priceForSleeping = budget - (budget * 0.80);
                        break;

                }
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{place} - {budget - priceForSleeping:f2}");
            }
            else if (budget > 1000) {
                place = "Hotel";
                destination = "Europe";
                priceForSleeping = budget - (budget * 0.90);
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{place} - {budget - priceForSleeping:f2}");
            }
        }
    }
}