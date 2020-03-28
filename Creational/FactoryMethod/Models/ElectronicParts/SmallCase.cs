namespace FactoryMethod.Models.ElectronicParts
{
    public class SmallCase : IElectronicPart
    {
        public string Name => "Small case for smartphones and tablets";
        public int Cost => 5;
    }
}
