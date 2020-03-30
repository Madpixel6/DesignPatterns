using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    internal abstract class CarFactory
    {
        public abstract SUV CreateSUV();
        public abstract Sedan CreateSedan();
    }
}
