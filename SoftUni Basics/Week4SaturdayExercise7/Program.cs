﻿using System;
namespace Week4SaturdayExercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int sumOfAllNumbers = 0;

            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumOfAllNumbers += currentNumber;
            }
            Console.WriteLine(sumOfAllNumbers);
        }   
    }
}