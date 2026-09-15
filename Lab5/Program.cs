/*
 * Student ID : 1690703135
 * Name       : Lab05
 * Section    : 129C
 * No.        : 27
 * Course     : GI113 Computer Programming (GI)
 */



namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("==>> DOG GAME <<==");
            Console.WriteLine("Hero vs Monster, Fight damage calculator\n");

            // Hero stat input HP,ATK, DEF
            Console.Write("Hero Health : ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack : ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense : ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stat input
            Console.Write("Monster Health : ");
            bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.Write("Monster Attack : ");
            bool monsterAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.Write("Monster Defense : ");
            bool monsterDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);

            // Input validation
            bool isHeroIntValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonsterIntValid = monsterHpOk && monsterAtkOk && monsterDefOk;
            Console.WriteLine($"\nHERO STATUS VALID : {isHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID : {isMonsterIntValid}");

            Console.WriteLine($"[HERO] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monsterHp}, ATK: {monsterAtk}, DEF: {monsterDef}");

            // Compound assignment : += simulate player drink potion before fight
            int potionHeal = 8;
            //heroHp = heroHp + potionHeal;     //Long form
            heroHp += potionHeal;               //Short form
            Console.WriteLine($"\nHero drink potion, heal {potionHeal} HP, new HP: {heroHp}");

            // Arithemetic + Normal Attack
            int normalDmg = Math.Max(0, heroAtk - monsterDef);                  // Normal attack damage calculation depend on monster DEF
            Console.WriteLine($"\nHero normal attack damage : {normalDmg} DMG");

            // Precedence Special Attack
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monsterDef);                 // Special attack damage calculation depend on monster DEF
            Console.WriteLine($"\nHero special attack damage : {pwrDmg} DMG");

            // Random, Simple percent of critical chance.
            Random criticalChance = new Random();
            int roll = criticalChance.Next(1, 101);             // Random number between 1 and 100. Alway +1 Max
            bool isCritical = roll <= 10;                       // 10% chance of critical hit
            int criticalDmg = normalDmg + Convert.ToInt32(isCritical) * normalDmg;
            Console.WriteLine($"\nCritical Hit roll: {roll}, (critical: {isCritical})");
            Console.WriteLine($"If critical, normal attack damage becomes: {criticalDmg} DMG");


        }
    }
}
