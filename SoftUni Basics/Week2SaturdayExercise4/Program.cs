using System;
namespace Week2SaturdayExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
            string passwordEntered = Console.ReadLine();

            if (passwordEntered == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }

            else {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}