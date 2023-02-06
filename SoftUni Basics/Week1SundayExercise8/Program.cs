using System;
namespace Week1SundayExercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int yearlyFee = int.Parse(Console.ReadLine());
            //Calculations
            double sneakersPrice = yearlyFee - (yearlyFee * 0.4);
            double suitPrice = sneakersPrice - (sneakersPrice * 0.2);
            double basketBall = suitPrice / 4;
            double accessories = basketBall / 5;

            //Output
            Console.WriteLine(yearlyFee + sneakersPrice + suitPrice
                + basketBall + accessories);
        }
    }
}