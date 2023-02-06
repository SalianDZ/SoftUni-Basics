using System;
namespace Week1SundayExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int nylon = int.Parse(Console.ReadLine()) + 2;
            int paintInLitres = int.Parse(Console.ReadLine());

            double paintInLitresWithBonus = paintInLitres + (paintInLitres * 0.1);

            int diluent = int.Parse(Console.ReadLine());
            int workingHours = int.Parse(Console.ReadLine());

            //Calculations 

            double nylonPrice = nylon * 1.50;
            double paintPrice = paintInLitresWithBonus * 14.50;
            double diluentPrice = diluent * 5.0;

            double totalPriceForMaterials = nylonPrice + paintPrice + diluentPrice + 0.40;
            double workersPay = totalPriceForMaterials * 0.3 * workingHours;

            //Output

            Console.WriteLine(totalPriceForMaterials + workersPay);

        }
    }
}