using System;
namespace Week2SundayExercisе3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMinutes = minutes + 15;
            if (newMinutes >= 60)
            {
                hours = hours + 1;
                newMinutes = newMinutes - 60;
            }
            if (hours > 23.59) {
                hours = 0;
            }
            if (newMinutes < 10)
            {
                Console.WriteLine($"{hours}:0{newMinutes}");
            }
            else {
                Console.WriteLine($"{hours}:{newMinutes}");
            }
        }
    }
}