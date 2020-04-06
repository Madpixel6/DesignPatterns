namespace Composite
{
    // Leaf, it can't have any children
    internal sealed class Soldier : Component
    {
        public override string Description => "A soldier unit";
        public override int Experience => 0;
        private const int ExpAmount = 10;

        public override int Train()
            => Experience += ExpAmount;
    }
}
