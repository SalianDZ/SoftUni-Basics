using System;
namespace Week5SundayExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coinsCounter = 0;

            while (change > 0)
            {
                if (change >= 2.00m)
                {
                    change -= 2.00m;
                    coinsCounter++;//1
                }
                else if (change >= 1.00m)
                {
                    change -= 1.00m;
                    coinsCounter++;
                }
                else if (change >= 0.50m) 
                {
                    change -= 0.50m;
                    coinsCounter++;//2
                }
                else if (change >= 0.20m)
                {
                    change -= 0.20m;
                    coinsCounter++;//3
                }
                else if (change >= 0.10m)
                {
                    change -= 0.10m;
                    coinsCounter++;
                }
                else if (change >= 0.05m)
                {
                    change -= 0.05m;
                    coinsCounter++;
                }
                else if (change >= 0.02m)
                {
                    change -= 0.02m;
                    coinsCounter++;//4
                }
                else
                {
                    change -= 0.01m;
                    coinsCounter++;//5
                }
            }
            Console.WriteLine(coinsCounter);
        }
    }
}