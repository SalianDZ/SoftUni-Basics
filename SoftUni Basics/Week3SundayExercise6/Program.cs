using System;
namespace Week3SundayExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            if (op == "+") {
                double result = numOne + numTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numOne} + {numTwo} = {result} - even");
                }
                else {
                    Console.WriteLine($"{numOne} + {numTwo} = {result} - odd");
                }


            }
            else if (op == "-") {
                double result = numOne - numTwo;
                if (result % 2 == 0) {
                    Console.WriteLine($"{numOne} - {numTwo} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{numOne} - {numTwo} = {result} - odd");
                }
            }
            else if (op == "*") {
                double result = numOne * numTwo;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{numOne} * {numTwo} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{numOne} * {numTwo} = {result} - odd");
                }
            }
            else if (op == "/")
            {
                if (numTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numOne} by zero");
                }
                else {
                    double result = numOne / (numTwo * 1.0);
                    Console.WriteLine($"{numOne} / {numTwo} = {result:f2}");
                }
            }
            else if (op == "%") {
                if (numTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numOne} by zero");
                }
                else
                {
                    double result = numOne % (numTwo);
                    Console.WriteLine($"{numOne} % {numTwo} = {result}");
                }
            }
             

            
        }
    }
}