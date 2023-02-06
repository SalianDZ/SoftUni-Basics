using System;
namespace Week1SundayExercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine()); 
            double percentages = double.Parse(Console.ReadLine()) / 100;
            //Calculations
            double volume = lenght * width * height;
            double litres = volume / 1000;
            double litresWithPercentages = litres - (litres * percentages);


            //Output
            Console.WriteLine(litresWithPercentages);


        }
    }
}