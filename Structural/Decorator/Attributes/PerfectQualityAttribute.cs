namespace Decorator.Attributes
{
    internal class PerfectQualityAttribute : AttributeDecorator
    {
        public override string Description => _item.Description + " of perfect quality";

        public override int Cost => _item.Cost + 3;

        public override int Defense => _item.Defense + 5;

        public override int Attack => _item.Attack + 4;

        public PerfectQualityAttribute(Item item) : base(item) { }
    }
}
