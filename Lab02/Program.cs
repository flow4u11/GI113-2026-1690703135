/*
 * Student ID : 1690703135
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            //6 Variables for the boss character

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");          //Part A: Boss Status

            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine();

            // Percent Calulation
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();

            //Boss HP Update
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");


            Console.WriteLine("===== DnD DARK FANTASY PARTY =====");            //Part B: Dark Fantasy Party

            // Character 1: Vampire Hunter
            string hunterName = "Victor";
            int hunterHp = 150;
            float hunterAttack = 45.5f;
            char hunterRank = 'A';
            bool hunterIsAlive = true;

            Console.WriteLine();

            Console.WriteLine("===== CHARACTER 1 =====");
            Console.WriteLine($"Name: {hunterName}");
            Console.WriteLine($"HP: {hunterHp}");
            Console.WriteLine($"Attack Power: {hunterAttack}");
            Console.WriteLine($"Rank: {hunterRank}");
            Console.WriteLine($"Is Alive: {hunterIsAlive}");

            // Character 2: Blood Mage
            string mageName = "Eliana";
            int mageMana = 180;
            double mageCritMultiplier = 1.75;
            char mageRank = 'S';
            bool mageCanUseMagic = true;

            Console.WriteLine("===== CHARACTER 2 =====");
            Console.WriteLine($"Name: {mageName}");
            Console.WriteLine($"Mana: {mageMana}");
            Console.WriteLine($"Crit Multiplier: {mageCritMultiplier}");
            Console.WriteLine($"Rank: {mageRank}");
            Console.WriteLine($"Can Use Magic: {mageCanUseMagic}");

            // Character 3: Undead Knight
            string knightName = "Baron";
            int knightArmor = 200;
            float knightSpeed = 6.5f;
            char knightRank = 'A';
            bool knightIsUndead = true;

            Console.WriteLine("===== CHARACTER 3 =====");
            Console.WriteLine($"Name: {knightName}");
            Console.WriteLine($"Armor: {knightArmor}");
            Console.WriteLine($"Movement Speed: {knightSpeed}");
            Console.WriteLine($"Rank: {knightRank}");
            Console.WriteLine($"Is Undead: {knightIsUndead}");

            // Character 4: Shadow Assassin
            string assassinName = "Nyx";
            int assassinHp = 100;
            double assassinDodgeChance = 67.5;
            float assassinAttackSpeed = 2.3f;
            bool assassinIsHidden = false;

            Console.WriteLine("===== CHARACTER 4 =====");
            Console.WriteLine($"Name: {assassinName}");
            Console.WriteLine($"HP: {assassinHp}");
            Console.WriteLine($"Dodge Chance: {assassinDodgeChance}%");
            Console.WriteLine($"Attack Speed: {assassinAttackSpeed}");
            Console.WriteLine($"Is Hidden: {assassinIsHidden}");

        }
    }
}
