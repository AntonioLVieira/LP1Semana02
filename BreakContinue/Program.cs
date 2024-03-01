using System;

namespace BreakContinue
{
    public class Program
    {
        private static void Main(string[] args)
        {
            const int maxTurns = 20;
            int turn = 0;
            while (true)
            {
                turn++;

                if (turn >= maxTurns)
                {
                    break;
                }

                if (turn % 3 == 0 || turn == 10)
                {
                    continue;
                }

                Console.WriteLine($"Turno número {turn}");
            }

            Console.WriteLine($"O último turno foi {turn}");
        }
    }
}