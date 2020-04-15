namespace Decorator.Attributes
{
    internal class HardnessAttribute : AttributeDecorator
    {
        public override string Description => _item.Description + " of hardness";
        public override int Cost => _item.Cost + 1;
        public override int Defense => _item.Defense + 7;
        public override int Attack => _item.Attack + 1;

        public HardnessAttribute(Item item) : base(item) { }
    }
}
