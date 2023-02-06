using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double depositSum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double anniversaryLoanPercentage = double.Parse(Console.ReadLine());

            //calculations
            double sum1 = (depositSum * (anniversaryLoanPercentage / 100)) / 12;
            double mainSum = depositSum + period * sum1;

            //output 
            Console.WriteLine(mainSum);
        }
    }
}