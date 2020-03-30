namespace Builder.Builders
{
    internal class CastleBuilder : Builder
    {
        private readonly Building _building = new Building();

        public override Building Instance() 
            => _building;

        public override void BuildFundaments()
            => _building.FundamentsDescription = "Spatial, lined with stone";

        public override void BuildWalls()
            => _building.WallType = WallType.Stone;

        public override void BuildRoof()
            => _building.RoofType = RoofType.Domed;
    }
}
