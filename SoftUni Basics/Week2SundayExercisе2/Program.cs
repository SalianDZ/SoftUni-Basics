namespace Week2SundayExercisе2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;
            if (startingPoints <= 100)
            {
                bonusPoints = bonusPoints + 5;
            }
            else if (startingPoints > 100 && startingPoints < 1000)
            {
                bonusPoints = startingPoints * 0.2;
            }
            else if (startingPoints > 1000)
            {
                bonusPoints = startingPoints * 0.1;
            }

            double additionalBonusPoints = 0;
            if (startingPoints % 2 == 0)
            {
                additionalBonusPoints = additionalBonusPoints + 1;
            }
            else if (startingPoints % 10 == 5)
            {
                additionalBonusPoints = additionalBonusPoints + 2;
            }
            Console.WriteLine(bonusPoints + additionalBonusPoints);
            Console.WriteLine(bonusPoints + additionalBonusPoints + startingPoints);
        }
    }
}