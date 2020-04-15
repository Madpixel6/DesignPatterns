using Decorator.Attributes;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            var sword = new Sword() { Description = "Titan sword" };
            var chestmail = new Chestmail() { Description = "Silver chestplate" };
            Console.WriteLine("Making a perfect quality version of the "+ sword.Description);
            var perfectQualitySword = new PerfectQualityAttribute(sword);
            Console.WriteLine("Making a hardened version of the " + chestmail.Description);
            var hardenedChestmail = new HardnessAttribute(chestmail);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("========== Attributes showcase ==========");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{nameof(Sword)} attributes:");
            Console.WriteLine($"{nameof(Sword.Description)}: {perfectQualitySword.Description}");
            Console.WriteLine($"{nameof(Sword.Cost)}: {perfectQualitySword.Cost} (base: {sword.Cost})");
            Console.WriteLine($"{nameof(Sword.Attack)}: {perfectQualitySword.Attack} (base: {sword.Attack})");
            Console.WriteLine($"{nameof(Sword.Defense)}: {perfectQualitySword.Defense} (base: {sword.Defense})");
            Console.WriteLine($"{nameof(Chestmail)} attributes:");
            Console.WriteLine($"{nameof(Chestmail.Description)}: {hardenedChestmail.Description}");
            Console.WriteLine($"{nameof(Chestmail.Cost)}: {hardenedChestmail.Cost} (base: {chestmail.Cost})");
            Console.WriteLine($"{nameof(Chestmail.Defense)}: {hardenedChestmail.Defense} (base: {chestmail.Defense})");

            Console.ReadKey();
        }
    }
}
