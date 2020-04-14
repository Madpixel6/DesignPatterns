
namespace Strategy
{
    internal class HeapSortStrategy : IStrategy
    {
        private int _heapSize;

        public void Execute(int[] array)
        {
            _heapSize = array.Length - 1;
            BuildHeap(array);
            for (var index = _heapSize; index > 0; index--)
            {
                Swap(ref array[0], ref array[index]);
                _heapSize--;
                Heapify(array, 0);
            }
            Program.PrintSortArray(array,"Heap sort", false);
        }

        private void BuildHeap(int[] array)
        {
            for (var i = _heapSize / 2; i >= 0; i--)
                Heapify(array, i);
        }
        // Restoring heap property
        // Consequent nodes: 2k oraz 2k+1
        // Predecessor node: k/2
        private void Heapify(int[] array, int index)
        {
            var root = index; // largest
            var leftIndex = 2 * index;
            var rightIndex = 2 * index + 1;

            if (leftIndex <= _heapSize && array[leftIndex] > array[index])
                root = leftIndex;

            if (rightIndex <= _heapSize && array[rightIndex] > array[root])
                root = rightIndex;

            if (root == index) return;

            Swap(ref array[index], ref array[root]);
            Heapify(array, root);
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
