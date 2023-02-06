using System;
using System.Security;

namespace Week6SundayExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeNumbersSum = 0;
            int nonPrimeNumbersSum = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }
                int currentNumber = int.Parse(command);
                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool isPrime = true;

                for (int i = 2; i < currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbersSum += currentNumber;
                }
                else
                {
                    nonPrimeNumbersSum += currentNumber;
                }

            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");
        }
    }
}