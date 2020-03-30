using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    internal class FiatFactory : CarFactory
    {
        public override SUV CreateSUV()
            => new SUV { Description = "Fiat made, affordable SUV!" };

        public override Sedan CreateSedan()
            => new Sedan { Description = "Fiat made, very affordable, sedan car" };
    }
}
