/*
 * Student ID : 1690703135
 * Name       : Assignment02
 * Section    : 129C
 * No.        : 27
 * Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Forge settings
            const string MaterialName = "Fire Opal";
            const string OreName = "Fire Opal Ore";
            const string IngotName = "Fire Opal Ingot";

            const double SmeltRate = 0.20;
            const double SalvageRate = 0.25;
            const double MaxBatch = 300;

            // Display forge information
            Console.WriteLine("===================================");
            Console.WriteLine("            THE FORGE");
            Console.WriteLine("===================================");
            Console.WriteLine($"Material     : {MaterialName}");
            Console.WriteLine($"Smelt Rate   : {SmeltRate}");
            Console.WriteLine($"Salvage Rate : {SalvageRate}");
            Console.WriteLine($"Max Batch    : {MaxBatch}");
            Console.WriteLine();

            // Menu options
            Console.WriteLine("[S] Smelt     : Ore -> Ingot");
            Console.WriteLine("[B] Breakdown : Ingot -> Ore");
            Console.WriteLine();

            // Get menu input
            Console.Write("Choose an action (S/B): ");
            bool menuOk = char.TryParse(Console.ReadLine(), out char menu);

            // Get amount input
            Console.Write($"Enter amount (Max {MaxBatch}): ");
            bool amountOk = double.TryParse(Console.ReadLine(), out double amount);

            Console.WriteLine();

            // Check if the amount is valid
            if (amountOk && amount > 0 && amount <= MaxBatch)
            {
                // Smelt Ore into Ingot
                if (menuOk && (menu == 'S' || menu == 's'))
                {
                    double ingotAmount = amount * SmeltRate;

                    Console.WriteLine("Smelting complete!");
                    Console.WriteLine(
                        $"=> {amount:F2} {OreName} ==> {ingotAmount:F2} {IngotName}");
                }

                // Breakdown Ingot into Ore
                else if (menuOk && (menu == 'B' || menu == 'b'))
                {
                    double oreAmount = amount / SalvageRate;

                    Console.WriteLine("Breakdown complete!");
                    Console.WriteLine(
                        $"=> {amount:F2} {IngotName} ==> {oreAmount:F2} {OreName}");
                }

                // Invalid menu
                else
                {
                    Console.WriteLine("Invalid action. Please enter S or B.");
                }
            }

            // Invalid amount
            else
            {
                Console.WriteLine(
                    $"Invalid amount. Please enter a number between 0.01 and {MaxBatch}.");
            }
        }
    }
}