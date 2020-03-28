namespace FactoryMethod.Models.ElectronicParts
{
    public class Screen : IElectronicPart
    {
        public string Name => "Screen";
        public int Cost => 100;
    }
}
