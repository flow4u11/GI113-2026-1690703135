/*
 * Student ID : 1690703135
 * Name       : Assignment01
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Character Info
            const string GameTitle = "Path of Exile 2";

            string characterClass = "Bloodmage";
            var characterName = "Kim";
            var buildName = "SparkDoubleCoC Bloodmage";
            char buildRank = 'S';
            int characterLevel = 97;
            float criticalChance = 42.5f;
            double damagePerSecond = 12345.67;
            bool isEndgameReady = true;

            double characterLevelAsDouble = characterLevel;

            int damageFromCast = (int)damagePerSecond;
            int damageFromConvert = Convert.ToInt32(characterLevelAsDouble);

            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine("|                 RANGER STAT CARD                   |");
            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine($"| Game            : {GameTitle}");
            Console.WriteLine($"| Character       : {characterName}");
            Console.WriteLine($"| Class           : {characterClass}");
            Console.WriteLine($"| Build           : {buildName}");
            Console.WriteLine($"| Build Rank      : {buildRank}");
            Console.WriteLine($"| Level           : {characterLevel}");
            Console.WriteLine($"| Critical Chance : {criticalChance}%");
            Console.WriteLine($"| Damage Per Sec  : {damagePerSecond}");
            Console.WriteLine($"| Endgame Ready   : {isEndgameReady}");
            Console.WriteLine("+----------------------------------------------------+");

            Console.WriteLine();

            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine("|                  TYPE CONVERSION                   |");
            Console.WriteLine("+----------------------------------------------------+");
            Console.WriteLine($"| Level as double       : {characterLevelAsDouble}");
            Console.WriteLine($"| DPS with cast         : {damageFromCast}");
            Console.WriteLine($"| DPS with Convert      : {damageFromConvert}");
            Console.WriteLine("+----------------------------------------------------+");
        }
    }
}
