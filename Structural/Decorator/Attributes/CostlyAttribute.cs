namespace Decorator.Attributes
{
    internal class CostlyAttribute : AttributeDecorator
    {
        public override string Description => _item.Description + "costly";
        public override int Attack => _item.Attack;
        public override int Defense => _item.Defense;
        public override int Cost => _item.Cost + 5;

        public CostlyAttribute(Item item) : base(item) { }
    }
}
