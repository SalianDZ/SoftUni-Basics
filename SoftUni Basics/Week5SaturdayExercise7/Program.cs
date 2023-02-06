using System;
namespace Week5SaturdayExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int userNumber = int.Parse(input);

                if (userNumber < minNumber)
                {
                    minNumber = userNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}