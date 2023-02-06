using System;
using System.Diagnostics.CodeAnalysis;

namespace Week5SaturdayExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double userNumber = double.Parse(input);
                if (userNumber <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else {
                    sum += userNumber;
                    Console.WriteLine($"Increase: {userNumber:f2}");
                    input = Console.ReadLine(); 
                }
            }
            Console.WriteLine($"Total: {sum:f2}");

        }
    }
}