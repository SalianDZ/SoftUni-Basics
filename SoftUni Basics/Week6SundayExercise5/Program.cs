using System;
namespace Week6SundayExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isOneDigitSpecial = false;
            int isSpecialCounter = 0;
            

            for (int i = 1111; i <= 9999; i++)
            {
                int currentNumber = i;
                isSpecialCounter = 0;

                while (true)
                {
                    int lastDigit = currentNumber % 10;
                    if (lastDigit == 0) {
                        break;
                    }
                    if (n % lastDigit == 0) {
                        isSpecialCounter++;
                    }
                    else
                    {
                        break;
                    }
                    if (isSpecialCounter == 4)
                    {
                        Console.Write(i + " ");
                    }
                    currentNumber = currentNumber / 10;
                    if (currentNumber == 0)
                    {
                        lastDigit = 0;
                        break;
                    }
                }
            }
        }
    }
}