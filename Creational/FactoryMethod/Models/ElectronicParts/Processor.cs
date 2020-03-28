namespace FactoryMethod.Models.ElectronicParts
{
    public class Processor : IElectronicPart
    {
        public string Name => "Wintell x580";
        public int Cost => 120;
    }
}
