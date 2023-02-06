using System;
namespace Week1SundayExercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double chikenMenu = int.Parse(Console.ReadLine()) * 10.35;
            double fishMenu = int.Parse(Console.ReadLine()) * 12.40;
            double veganMenu = int.Parse(Console.ReadLine()) * 8.15;

            //Calculations

            double delivery = 2.50;
            double dessert = (chikenMenu + fishMenu + veganMenu) * 0.2;
            double sum = chikenMenu + fishMenu + veganMenu + dessert + delivery;

            //Output
            Console.WriteLine(sum);
        }
    }
}