namespace Builder
{
    public enum WallType
    {
        Wooden,
        Stone
    }

    public enum RoofType
    {
        Flat,
        Domed,
        Dutch
    }

    internal class Building
    {
        public string FundamentsDescription { get; set; }
        public WallType WallType { get; set; }
        public RoofType RoofType { get; set; }
        public override string ToString()
            => $"A building with {WallType.ToString()} walls, {RoofType.ToString()} roof, and {FundamentsDescription} fundaments";
    }
}
