namespace Strategy
{
    internal class SortContext
    {
        private IStrategy _strategy;
        public SortContext(IStrategy strategy)
            => _strategy = strategy;
        public void SetStrategy(IStrategy destinationStrategy)
            => _strategy = destinationStrategy;
        public void ExecuteStrategy(int[] array)
            => _strategy.Execute(array);
    }
}
