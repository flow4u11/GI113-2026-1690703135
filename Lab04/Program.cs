/*
 * Student ID : 1690703135
 * Name       : Lab04
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string characterName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int characterNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{characterName} the Class-{characterNum} adventurer enters the dungeon. Luck: {luck}");
        }
    }
}
