using System;
namespace Week3SundayExercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double roomForOne = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;
            int nights = days - 1;
            double cost = 0;

            if (roomType == "room for one person")
            {
                cost = nights * roomForOne;
                if (rating == "positive")
                {
                    cost = cost + (cost * 0.25);
                }
                else
                {
                    cost = cost - (cost * 0.10);
                }
            }
            else if (roomType == "apartment") {
                cost = nights * apartment;
                if (days < 10) {
                    cost = cost - (cost * 0.30);
                }
                else if (days >= 10 && days <= 15) {
                    cost = cost - (cost * 0.35);
                }
                else if (days > 15) {
                    cost = cost - (cost * 0.50);
                }
                if (rating == "positive")
                {
                    cost = cost + (cost * 0.25);
                }
                else
                {
                    cost = cost - (cost * 0.10);
                }
            }
            else if (roomType == "president apartment") {
                cost = nights * presidentApartment;
                if (days < 10)
                {
                    cost = cost - (cost * 0.10);
                }
                else if (days >= 10 && days <= 15)
                {
                    cost = cost - (cost * 0.15);
                }
                else if (days > 15)
                {
                    cost = cost - (cost * 0.20);
                }
                if (rating == "positive")
                {
                    cost = cost + (cost * 0.25);
                }
                else
                {
                    cost = cost - (cost * 0.10);
                }
            }
            Console.WriteLine($"{cost:f2}");    
        }
    }
}