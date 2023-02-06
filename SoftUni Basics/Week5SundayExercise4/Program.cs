using System;
namespace Week5SundayExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsSum = 0;

            while (stepsSum < 10000)
            {
                string comand = Console.ReadLine();
                if (comand == "Going home")
                {
                    int steps = int.Parse(Console.ReadLine());
                    stepsSum += steps;
                    if (stepsSum < 10000)
                    {
                        Console.WriteLine($"{10000 - stepsSum} more steps to reach goal.");
                        break;
                    }
                }
                else
                {
                    stepsSum+= int.Parse(comand);
                }

            }
            if (stepsSum > 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsSum - 10000} steps over the goal!");
            }
            
            //int stepsSum = 0;
            //while (true)
            //{
            //    string comand = Console.ReadLine();
            //    if (comand == "Going home")
            //    {
            //        int steps = int.Parse(Console.ReadLine());
            //        stepsSum += steps;
            //        if (stepsSum < 10_000)
            //        {
            //            Console.WriteLine($"{10_000 - stepsSum} more steps to reach goal.");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Goal reached! Good job!");
            //            Console.WriteLine($"{stepsSum - 10_000} steps over the goal!");
            //        }
            //    }
            //    else
            //    {
            //        int steps = int.Parse(comand);
            //        stepsSum += steps;

            //        if (stepsSum >= 10_000)
            //        {
            //            Console.WriteLine("Goal reached! Good job!");
            //            Console.WriteLine($"{stepsSum - 10_000} steps over the goal!");
            //        }
            //    }
            //}
        }
    }
}