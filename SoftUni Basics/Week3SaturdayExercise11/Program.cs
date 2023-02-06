using System;
namespace Week3SaturdayExercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                if (fruit == "banana")
                {
                    sum = quantity * 2.50;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "apple")
                {
                    sum = quantity * 1.20;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "orange")
                {
                    sum = quantity * 0.85;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    sum = quantity * 1.45;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "kiwi")
                {
                    sum = quantity * 2.70;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "pineapple")
                {
                    sum = quantity * 5.50;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapes")
                {
                    sum = quantity * 3.85;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (fruit == "banana")
                {
                    sum = quantity * 2.70;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "apple")
                {
                    sum = quantity * 1.25;
                    Console.WriteLine($"{sum:f2}");
                }

                else if (fruit == "orange")
                {
                    sum = quantity * 0.90;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    sum = quantity * 1.60;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "kiwi")
                {
                    sum = quantity * 3.00;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "pineapple")
                {
                    sum = quantity * 5.60;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (fruit == "grapes")
                {
                    sum = quantity * 4.20;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else { 
                Console.WriteLine("error");
            }

        }


    }
}