using System;

namespace Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var random = new Random();
            var amountOfSoldiers = random.Next(9, 15);
            Console.WriteLine($"Creating the tactical unit, consisting {amountOfSoldiers} soldiers");
            var teamUnit = new TacticalUnit();
            for (var soldierIndex = 0; soldierIndex < amountOfSoldiers; soldierIndex++)
            {
                teamUnit.Add(new Soldier 
                    { Description = $"Soldier number{soldierIndex}" }
                );
            }

            var amountOfTrainings = random.Next(2, 8);
            Console.WriteLine($"Training the unit {amountOfTrainings} times");
            for(var trainingIndex = 0; trainingIndex < amountOfTrainings; trainingIndex++)
                teamUnit.Train();
            
            Console.WriteLine("Total unit experience: " + teamUnit.Experience);
            Console.ReadKey();
        }
    }
}
