using System;

namespace Strategy
{
    internal static class Program
    {
        static void Main()
        {
            var context = new SortContext(new HeapSortStrategy());
            var exampleArray = GenerateIntegerArray();

            PrintSortArray(exampleArray, "Heap sort", true);
            context.ExecuteStrategy(exampleArray);

            Console.WriteLine("Changing strategy...");

            context.SetStrategy(new CountingSortStrategy());
            exampleArray = GenerateIntegerArray();
            PrintSortArray(exampleArray, "Counting sort", true);
            context.ExecuteStrategy(exampleArray);

            Console.ReadKey();
        }
        private static int[] GenerateIntegerArray()
        {
            var random = new Random();
            var array = new int[5];
            for(var index = 0; index < array.Length; index++)
                array[index] = random.Next(0, 100);
            return array;
        }
        public static void PrintSortArray(in int[] array, string sortType, bool isInput)
        {
            Console.WriteLine(sortType + (isInput ? " input": " output") + " array: ");
            foreach (var item in array)
                Console.Write(item + " ");
            Console.Write('\n');
        }
    }
}
