using System;
using System.Diagnostics.CodeAnalysis;

namespace Week3SaturdayExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string town = Console.ReadLine();   
            double quantity = double.Parse(Console.ReadLine());
            double sum = 0;

            if (town == "Sofia") {
                if (productName == "coffee") {
                    sum = quantity * 0.50;
                }
                else if (productName == "water") {
                    sum = quantity * 0.80;
                }
                else if (productName == "beer") {
                    sum = quantity * 1.20;
                }
                else if (productName == "sweets") {
                    sum = quantity * 1.45;
                }
                else if (productName == "peanuts") {
                    sum = quantity * 1.60;
                }
            }
            else if (town == "Plovdiv") {
                if (productName == "coffee") {
                    sum = quantity * 0.40;
                }
                else if (productName == "water")
                {
                    sum = sum + (quantity * 0.70);
                }
                else if (productName == "beer")
                {
                    sum = quantity * 1.15;
                }
                else if (productName == "sweets")
                {
                    sum = quantity * 1.30;
                }
                else if (productName == "peanuts")
                {
                    sum = quantity * 1.50;
                }
            }
            else if (town == "Varna") {
                if (productName == "coffee") {
                    sum = quantity * 0.45;
                }
                else if (productName == "water")
                {
                    sum = quantity * 0.70;
                }
                else if (productName == "beer")
                {
                    sum = quantity * 1.10;
                }
                else if (productName == "sweets")
                {
                    sum = quantity * 1.35;
                }
                else if (productName == "peanuts")
                {
                    sum = quantity * 1.55;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}