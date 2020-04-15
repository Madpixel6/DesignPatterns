namespace Decorator
{
    // Base decorator, wraps all concrete decorators
    internal abstract class AttributeDecorator : Item
    {
        protected Item _item;
        public abstract override string Description { get; }

        public AttributeDecorator(Item item)
            => _item = item;
    }
}
