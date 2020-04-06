using System.Collections.Generic;

namespace Composite
{
    internal class TacticalUnit : Component
    {
        protected List<Component> Components = new List<Component>();

        public override string Description => "A tactical unit";
        public override void Add(Component component)
            => Components.Add(component);

        public override void Remove(Component component)
            => Components.Remove(component);

        public override int Train()
        {
            foreach (var unit in Components)
            {
                Experience += unit.Train();
            }
            return Experience;
        }
    }
}
