using System;
namespace Week5SaturdayExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxNumber = int.MinValue;

            while (input != "Stop")
            {
                int userNumber = int.Parse(input);

                if (userNumber > maxNumber)
                {
                    maxNumber = userNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}