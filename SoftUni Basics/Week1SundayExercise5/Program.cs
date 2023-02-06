using System;
namespace Week1SundayExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double numberPensBought = double.Parse(Console.ReadLine());
            double numberMarkersBought = double.Parse(Console.ReadLine());   
            double numberCleanersBought = double.Parse(Console.ReadLine());
            double discountInPercentage = double.Parse(Console.ReadLine());

            //Calculations 
            double pensPrice = 5.80;
            double markersPrice = 7.20;
            double cleanersPriceForLiter = 1.20;

            double discountInNumbers = discountInPercentage / 100;





            double sumWithoutDiscount = (numberPensBought * pensPrice) + (numberMarkersBought * markersPrice) +(numberCleanersBought * cleanersPriceForLiter);
            double sumWithDiscount = sumWithoutDiscount - (sumWithoutDiscount * discountInNumbers);

            //output
            Console.WriteLine(sumWithDiscount);
        }
    }
}