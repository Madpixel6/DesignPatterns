using AbstractFactory.Factories;
using AbstractFactory.Models;
using System;

namespace AbstractFactory
{
    internal class Client
    {

        internal void MakeCars()
        {
            Console.WriteLine("Audi factory: ");
            var cars = CreateCars(new AudiFactory());
            OutputCarsDescription(cars);

            Console.WriteLine("========================== \n" +
                              "Fiat factory: ");
            cars = CreateCars(new FiatFactory());
            OutputCarsDescription(cars);
        }

        private void OutputCarsDescription(ValueTuple<ICar, ICar> cars)
        {
            Console.WriteLine($"First car description: {cars.Item1.Description}");
            Console.WriteLine($"Second car description: {cars.Item2.Description}");
        }

        private (SUV, Sedan) CreateCars(CarFactory factory)
            => (factory.CreateSUV(), factory.CreateSedan());
    }
}
