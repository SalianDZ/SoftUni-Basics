using System;
namespace Week6SundayExercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ticketCounter = 0;
            int studentTicketCounter = 0;
            int standardTicketCounter = 0;
            int kidTicketCounter = 0;
            int ticketCounterPerMovie = 0;
            while (true)
            {
                string command = Console.ReadLine();
                ticketCounterPerMovie = 0;
                if (command == "Finish") {
                    break;
                }
                int freeSeats = int.Parse(Console.ReadLine());
                while (true)
                {
                    string secondCommand = Console.ReadLine();
                    if (secondCommand == "End")
                    {
                        Console.WriteLine($"{command} - {(ticketCounterPerMovie * 1.0 / freeSeats) * 100:f2}% full.");
                        break;
                    }
                    ticketCounter++;
                    ticketCounterPerMovie++;
                    if (secondCommand == "student") {
                        studentTicketCounter++;
                    }
                    if (secondCommand == "standard")
                    {
                        standardTicketCounter++;
                    }
                    if (secondCommand == "kid")
                    {
                        kidTicketCounter++;
                    }
                    if (ticketCounterPerMovie >= freeSeats)
                    {
                        Console.WriteLine($"{command} - 100.00% full.");
                        ticketCounterPerMovie = 0;
                        break;
                    }
                }
            }
            Console.WriteLine($"Total tickets: {ticketCounter}");
            Console.WriteLine($"{(studentTicketCounter * 1.0 / ticketCounter) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTicketCounter * 1.0  / ticketCounter) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidTicketCounter * 1.0  / ticketCounter) * 100:f2}% kids tickets.");
        }
    }
}