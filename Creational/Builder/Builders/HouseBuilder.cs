namespace Builder.Builders
{
    internal class HouseBuilder : Builder
    {
        private readonly Building _building = new Building();

        public override Building Instance() 
            => _building;

        public override void BuildFundaments()
            => _building.FundamentsDescription = "medium-sized";

        public override void BuildWalls()
            => _building.WallType = WallType.Wooden;

        public override void BuildRoof()
            => _building.RoofType = RoofType.Dutch;
    }
}
