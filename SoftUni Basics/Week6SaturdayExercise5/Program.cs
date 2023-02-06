using System;
namespace Week6SaturdayExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double savedMoney = 0;

            while (destination != "End")
            {
                double tripCost = double.Parse(Console.ReadLine());
                savedMoney = 0;
                
                while (savedMoney < tripCost)
                {
                    double payment = double.Parse(Console.ReadLine());
                    savedMoney += payment;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}