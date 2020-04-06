using System;

namespace Composite
{
    // Base class of composition
    internal class Component
    {
        public virtual string Description { get; set; }
        public virtual int Experience { get; set; }

        public virtual void Add(Component component) => throw new NotImplementedException();
        public virtual void Remove(Component component) => throw new NotImplementedException();
        public virtual int Train() => throw new NotImplementedException();
    }
}
