using System;
namespace Week4SaturdayExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i <= word.Length - 1; i++)
            {
                Console.WriteLine(word[i]);
            }
        }
    }
}