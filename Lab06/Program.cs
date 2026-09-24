/*
 * Student ID : 1690703135
 * Name       : Lab06
 * Section    : 129C
 * No.        : 27
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== HSR TURN-BASED BATTLE ===");
            Console.WriteLine("An enemy appears!");
            Console.WriteLine("Your turn!");
            Console.WriteLine();

            Console.WriteLine("[1] Basic Attack");
            Console.WriteLine("[2] Heavy Attack");
            Console.WriteLine("[3] Ultimate Skill");
            Console.WriteLine();

            Console.Write("Choose your action (1-3): ");

            bool inputOk = int.TryParse(Console.ReadLine(), out int action);

            Console.WriteLine();

            if (!inputOk || action < 1 || action > 3)
            {
                Console.WriteLine("Invalid action.");
            }
            else if (action == 1)
            {
                Console.WriteLine("You use Basic Attack.");
                Console.WriteLine("The enemy takes 25 damage.");
            }
            else if (action == 2)
            {
                Console.WriteLine("You use Heavy Attack.");
                Console.WriteLine("The enemy takes 50 damage.");
            }
            else
            {
                Console.WriteLine("You use Ultimate Skill.");
                Console.WriteLine("The enemy takes 100 damage.");
            }

            Console.WriteLine();
            Console.WriteLine("Turn complete.");
        }
    }
}