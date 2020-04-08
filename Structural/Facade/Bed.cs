namespace Facade
{
    internal class Bed
    {
        public bool IsArranged { get; private set; }

        public void Arrange()
            => IsArranged = !IsArranged;
        public int Sleep()
        {
            IsArranged = false;
            return 10;
        }
    }
}
