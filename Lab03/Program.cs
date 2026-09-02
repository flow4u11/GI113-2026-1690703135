/*
* Student ID : 1690703135
* Name       : Lab03
* Section    : 129C
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;
            var bossName = "Kirin";
            var rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Save Game Data
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level} / {MaxLevel}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine();

            // Implicit Conversion
            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");

            Console.WriteLine();

            // HP Percent
            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            Console.WriteLine();

            // Explicit Cast
            Console.WriteLine("----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");

            Console.WriteLine();

            Console.WriteLine("----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}