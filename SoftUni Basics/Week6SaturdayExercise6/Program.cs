using System;
namespace Week6SaturdayExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsNumber = int.Parse(Console.ReadLine());
            int roomsNumber = int.Parse(Console.ReadLine());

            for (int floor = floorsNumber; floor >= 1; floor--)
            {
                for (int room = 0; room < roomsNumber; room++)
                {
                    if (floor == floorsNumber)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    if (floor % 2 == 0 && floor != floorsNumber)
                    {
                        //Тук ще са офисите
                        Console.Write($"O{floor}{room} ");
                    }
                    else if (floor % 2 != 0 && floor != floorsNumber)
                    {
                        //Тук ще са апартаментите
                        Console.Write($"A{floor}{room} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}