using System;
namespace Week4SundayExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int sumCollectedFromBirthday = 0;
            int sumCollectedFromToys = 0;
            int sum = 0;
            int timesReceived = 0;
            int newMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) {
                    newMoney += 10;
                    sumCollectedFromBirthday = (sumCollectedFromBirthday + newMoney);
                }
                else {
                    sumCollectedFromToys = sumCollectedFromToys + toyPrice;
                }
            }
            sum = (sumCollectedFromBirthday + sumCollectedFromToys) - (age / 2);
            double enoughMoney = sum - washingMachinePrice;

            if (sum >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {enoughMoney:f2}");
            }
            else {
                Console.WriteLine($"No! {washingMachinePrice - sum:f2}");
            }

        }

        
    }
}