using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double sum = a * a;
                Console.WriteLine($"{sum:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double sum = a * b;
                Console.WriteLine($"{sum:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double sum = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{sum:f3}");
            }
            else if (figure == "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double sum = (lenght * height) / 2;
                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}