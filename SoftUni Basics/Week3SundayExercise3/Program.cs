using System;
namespace Week3SundayExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double discountSum = 0;

            if (flowersType == "Roses")
            {
                if (flowersCount > 80)
                {
                    double sum = flowersCount * 5.0;
                    discountSum = sum - (sum * 0.10);

                    if (budget >= discountSum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - discountSum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {discountSum - budget:f2} leva more.");
                    }
                }
                else {
                    double sum = flowersCount * 5.0;

                    if (budget >= sum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - sum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                    }
                }
            }
            else if (flowersType == "Dahlias")
            {
                if (flowersCount > 90)
                {
                    double sum = flowersCount * 3.80;
                    discountSum = sum - (sum * 0.15);

                    if (budget >= discountSum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - discountSum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {discountSum - budget:f2} leva more.");
                    }
                }
                else
                {
                    double sum = flowersCount * 3.80;

                    if (budget >= sum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - sum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                    }
                }
            }
            else if (flowersType == "Tulips")
            {
                if (flowersCount > 80)
                {
                    double sum = flowersCount * 2.80;
                    discountSum = sum - (sum * 0.15);

                    if (budget >= discountSum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - discountSum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {discountSum - budget:f2} leva more.");
                    }
                }
                else
                {
                    double sum = flowersCount * 2.80;

                    if (budget >= sum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - sum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                    }
                }
            }
            else if (flowersType == "Narcissus")
            {
                if (flowersCount < 120)
                {
                    double sum = flowersCount * 3.00;
                    discountSum = sum + (sum * 0.15);

                    if (budget >= discountSum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - discountSum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {discountSum - budget:f2} leva more.");
                    }
                }
                else
                {
                    double sum = flowersCount * 3.00;

                    if (budget >= sum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - sum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                    }
                }
            }
            else if (flowersType == "Gladiolus")
            {
                if (flowersCount < 80)
                {
                    double sum = flowersCount * 2.50;
                    discountSum = sum + (sum * 0.20);

                    if (budget >= discountSum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - discountSum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {discountSum - budget:f2} leva more.");
                    }
                }
                else
                {
                    double sum = flowersCount * 2.50;

                    if (budget >= sum)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowersType} and {budget - sum:f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
                    }
                }
            }
        }
    }
}