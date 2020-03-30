namespace Builder.Builders
{
    internal abstract class Builder
    {
        public virtual Building Instance() => new Building();

        public abstract void BuildFundaments();
        public abstract void BuildWalls();
        public abstract void BuildRoof();
    }
}
