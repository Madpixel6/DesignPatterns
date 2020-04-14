using System.Linq;

namespace Strategy
{
    internal class CountingSortStrategy : IStrategy
    {
        public void Execute(int[] array)
        {
            var inputSize = array.Length;
            var maximum = array.Max();
            var countArray = new int[maximum + 1];
            var sortedArray = new int[inputSize];

            for (var index = 0; index < inputSize; index++)
                countArray[array[index]]++;
            // countArray[index] has a number of occurences
            for (var index = 1; index <= maximum; index++)
                countArray[index] += countArray[index - 1];

            for (var index = inputSize - 1; index >= 0; index--)
            {
                sortedArray[countArray[array[index]] - 1] = array[index];
                countArray[array[index]]--; // decreasing provided number count
            }

            Program.PrintSortArray(sortedArray, "Counting sort", false);
        }
    }
}
