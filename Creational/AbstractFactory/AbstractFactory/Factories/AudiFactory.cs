using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    internal class AudiFactory : CarFactory
    {
        public override SUV CreateSUV()
            => new SUV { Description = "Audi made, high quality and spacious SUV" };


        public override Sedan CreateSedan()
            => new Sedan { Description = "Audi made, affordable sedan!" };
    }
}
