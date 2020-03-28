using System.Collections.Generic;
using FactoryMethod.Models.ElectronicParts;

namespace FactoryMethod.Models
{
    // Abstract creator
    public abstract class Product
    {
        public List<IElectronicPart> Parts = new List<IElectronicPart>();

        public virtual string Description { get; set; }

        public abstract void CreateProduct(string productDescription);
    }
}
