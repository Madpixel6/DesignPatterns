using System;

namespace Decorator
{
    // Basic decorator class
    internal abstract class Item : IDisposable
    {
        public virtual string Description { get; set; } = "Default item description";
        public abstract int Cost { get; }
        public abstract int Defense { get; }
        public abstract int Attack { get; }

        public void Dispose()
            => Console.WriteLine("Item has been destroyed!");
    }
    internal class Sword : Item
    {
        public override int Cost => 6;
        public override int Defense => 2;
        public override int Attack => 10;
    }
    internal class Chestmail : Item
    {
        public override int Cost => 10;
        public override int Defense => 10;
        public override int Attack => 0;
    }
}
