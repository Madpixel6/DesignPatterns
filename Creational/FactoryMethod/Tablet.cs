using FactoryMethod.Models;
using FactoryMethod.Models.ElectronicParts;

namespace FactoryMethod
{
    // Concrete creator
    public class Tablet : Product
    {
        public override void CreateProduct(string productDescription)
        {
            Description = $"{nameof(Tablet)}" + productDescription;
            Parts.Add(new SmallCase());
            Parts.Add(new Screen());
            Parts.Add(new Processor());
        }
    }
}
