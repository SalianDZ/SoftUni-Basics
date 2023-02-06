using System;
namespace Week4SundayExercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            string mountainName = "";
            double sum = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;

            for (int i = 1; i <= groupsCount; i++) {
                int peopleCount = int.Parse(Console.ReadLine());

                if (peopleCount < 6)
                {
                    sum1 += peopleCount;
                    sum += peopleCount;
                    //Мусала
                }
                else if (peopleCount < 13)
                {
                    sum2 += peopleCount;
                    sum += peopleCount;
                    //Монблан
                }
                else if (peopleCount < 26)
                {
                    sum3 += peopleCount;
                    sum += peopleCount;
                    //Килиманджаро
                }
                else if (peopleCount < 41)
                {
                    sum4 += peopleCount;
                    sum += peopleCount;
                    //К2
                }
                else {
                    sum5 += peopleCount;
                    sum += peopleCount;
                    //Еверест
                }
            }
            Console.WriteLine($"{(sum1 / sum) * 100:f2}%");
            Console.WriteLine($"{(sum2 / sum) * 100:f2}%");
            Console.WriteLine($"{(sum3 / sum) * 100:f2}%");
            Console.WriteLine($"{(sum4 / sum) * 100:f2}%");
            Console.WriteLine($"{(sum5 / sum) * 100:f2}%");
        }
    }
}