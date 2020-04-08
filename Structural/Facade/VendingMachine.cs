using System;

namespace Facade
{
    internal class VendingMachine
    {
        private enum EnergyAmounts
        {
            EnergyDrink = 5,
            RandomDrink = 3
        }

        public int GetEnergyDrink()
        {
            Console.WriteLine("Took an energy drink");
            return (int)EnergyAmounts.EnergyDrink;
        }

        public int GetSomethingToDrink()
        {
            Console.WriteLine("Took something to drink");
            return (int)EnergyAmounts.RandomDrink;
        }
    }
}
