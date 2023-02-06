using System;
namespace Week3SundayExercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;
            double studioCost = 0;
            double apartmentCost = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50.0;
                studioCost = nights * studioPrice;
                apartmentPrice = 65.0;
                apartmentCost = nights * apartmentPrice;
                if (nights > 7 && nights <= 14)
                {
                    studioCost = studioCost - (studioCost * 0.05);
                }
                else if (nights > 14)
                {
                    studioCost = studioCost - (studioCost * 0.30);
                    apartmentCost = apartmentCost - (apartmentCost * 0.10);
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                studioCost = studioPrice * nights;
                apartmentPrice = 68.70;
                apartmentCost = apartmentPrice * nights;
                if (nights > 14)
                {
                    studioCost = studioCost - (studioCost * 0.2);
                    apartmentCost = apartmentCost - (apartmentCost * 0.10);

                }
            }
            else if (month == "July" || month == "August") {
                studioPrice = 76.0;
                studioCost = studioPrice * nights;
                apartmentPrice = 77.0;
                apartmentCost = apartmentPrice * nights;
                if (nights > 14) {
                    apartmentCost = apartmentCost - (apartmentCost * 0.10);
                }
                
            }
            Console.WriteLine($"Apartment: {apartmentCost:f2} lv.");
            Console.WriteLine($"Studio: {studioCost:f2} lv.");
        }
    }
}