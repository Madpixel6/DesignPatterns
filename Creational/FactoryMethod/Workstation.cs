using FactoryMethod.Models;
using FactoryMethod.Models.ElectronicParts;

namespace FactoryMethod
{
    // Concrete creator
    public class Workstation : Product
    {
        public override void CreateProduct(string productDescription)
        {
            Description = "[*Workstation*] " + productDescription;
            Parts.Add(new Screen());
            Parts.Add(new Processor());
            Parts.Add(new DedicatedGPU());
            Parts.Add(new BigCase());
        }
    }
}
