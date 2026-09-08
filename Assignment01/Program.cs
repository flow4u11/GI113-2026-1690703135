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


        }
    }
}
