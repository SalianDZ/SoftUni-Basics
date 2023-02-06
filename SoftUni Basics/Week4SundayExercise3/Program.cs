using System;
namespace Week4SundayExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double percentageP1 = 0;
            double percentageP2 = 0;
            double percentageP3 = 0;
            double percentageP4 = 0;
            double percentageP5 = 0;

            for (int i = 1; i <= numbersCount; i++) {
                int userNumber = int.Parse(Console.ReadLine());

                if (userNumber < 200)
                {
                    p1++;
                    percentageP1 = p1 / numbersCount * 100;
                }
                else if (userNumber < 400)
                {
                    p2++;
                    percentageP2 = p2 / numbersCount * 100;
                }
                else if (userNumber < 600)
                {
                    p3++;
                    percentageP3 = p3 / numbersCount * 100;
                }
                else if (userNumber < 800)
                {
                    p4++;
                    percentageP4 = p4 / numbersCount * 100;
                }
                else {
                    p5++;
                    percentageP5 = p5 / numbersCount * 100;
                }
            }
            Console.WriteLine($"{percentageP1:f2}%");
            Console.WriteLine($"{percentageP2:f2}%");
            Console.WriteLine($"{percentageP3:f2}%");
            Console.WriteLine($"{percentageP4:f2}%");
            Console.WriteLine($"{percentageP5:f2}%");
        }
    }
}