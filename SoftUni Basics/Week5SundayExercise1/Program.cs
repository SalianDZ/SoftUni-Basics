using System;
namespace Week5SundayExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int searchCounter = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {searchCounter} books.");
                    break;
                }
                if (command == searchedBook)
                {
                    Console.WriteLine($"You checked {searchCounter} books and found it.");
                    break;
                }
                searchCounter++;
            }

        }
    }
}