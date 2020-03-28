using FactoryMethod.Models;
using FactoryMethod.Models.ElectronicParts;

namespace FactoryMethod
{
    // Concrete creator
    public class Laptop : Product
    {
        public override void CreateProduct(string productDescription)
        {
            Description = $"[{nameof(Laptop)}] " + productDescription;
            Parts.Add(new Processor());
            Parts.Add(new Screen());
            Parts.Add(new BigCase());
        }
    }
}
