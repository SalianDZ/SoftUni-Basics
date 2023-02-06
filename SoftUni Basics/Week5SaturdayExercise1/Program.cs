using System;
namespace Week5SaturdayExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userWord = Console.ReadLine();

            while (userWord != "Stop")
            {
                Console.WriteLine(userWord);
                userWord = Console.ReadLine();
            }
        }
    }
}