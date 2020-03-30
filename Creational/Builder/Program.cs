using System;
using System.Collections.Generic;
using Builder.Builders;

namespace Builder
{
    internal class Program
    {
        private static readonly List<Building> Buildings = new List<Building>(3);

        static void Main(string[] args)
        {
            var buildDirector = new Director();

            Buildings.Add(buildDirector.Build(new CastleBuilder()));
            Buildings.Add(buildDirector.Build(new HouseBuilder()));
            Buildings.Add(buildDirector.Build(new HutBuilder()));

            foreach (var building in Buildings)
            {
                Console.WriteLine(building);
            }

            Console.ReadKey();
        }
    }
}
