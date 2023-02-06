using System;
namespace Week4SundayExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= openTabs; i++)
            {
                string tabName = Console.ReadLine();
                switch (tabName)
                {
                    case "Facebook": salary = salary - 150; break;
                    case "Instagram": salary = salary - 100; break;
                    case "Reddit": salary = salary - 50; break;
                }   
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }

            else
            {
                Console.WriteLine("You have lost your salary.");
            }

        }
    }
}