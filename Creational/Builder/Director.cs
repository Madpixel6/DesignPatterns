namespace Builder
{
    internal class Director
    {
        public Building Build(Builders.Builder builder)
        {
            builder.BuildFundaments();
            builder.BuildWalls();
            builder.BuildRoof();
            return builder.Instance();
        }
    }
}
