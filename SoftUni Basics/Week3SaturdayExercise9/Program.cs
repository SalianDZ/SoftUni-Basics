﻿using System;
namespace Week3SaturdayExercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();

            switch (productName)
            {
                case "banana": Console.WriteLine("fruit"); break;
                case "apple": Console.WriteLine("fruit"); break;
                case "kiwi": Console.WriteLine("fruit"); break;
                case "cherry": Console.WriteLine("fruit"); break;
                case "lemon": Console.WriteLine("fruit"); break;
                case "grapes": Console.WriteLine("fruit"); break;
                case "tomato": Console.WriteLine("vegetable"); break;
                case "cucumber": Console.WriteLine("vegetable"); break;
                case "pepper": Console.WriteLine("vegetable"); break;
                case "carrot": Console.WriteLine("vegetable"); break;
                default: Console.WriteLine("unknown");
                    break;
            }
        }
    }
}