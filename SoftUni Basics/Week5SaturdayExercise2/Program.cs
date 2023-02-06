using System;
namespace Week5SaturdayExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != password)
            {
                input = Console.ReadLine();

            }
            Console.WriteLine($"Welcome {username}!");

        }
    }
}