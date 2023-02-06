using System;
namespace Week3SundayExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeProject = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double sum = 0;

            if (typeProject == "Premiere") {
                sum = (r * c) * 12.0;
                Console.WriteLine($"{sum:f2}  leva");
            }
            else if (typeProject == "Normal") {
                sum = (r * c) * 7.50;
                Console.WriteLine($"{sum:f2} leva");
            }
            else if (typeProject == "Discount")
            {
                sum = (r * c) * 5.00;
                Console.WriteLine($"{sum:f2} leva");
            }

        }
    }
}