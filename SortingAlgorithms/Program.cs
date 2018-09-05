using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. QuickSort
            Console.WriteLine("1. QuickSort");

            int[] arr1 = { 3, 4, 1, 2 };
            Console.WriteLine($"\nStarting array: {string.Join(" ", arr1)}");
            QuickSort(arr1, 0, arr1.Length - 1);
            Console.WriteLine($"Ending array: {string.Join(" ", arr1)}");

            int[] arr2 = { 3 };
            Console.WriteLine($"\nStarting array: {string.Join(" ", arr2)}");
            QuickSort(arr2, 0, arr2.Length - 1);
            Console.WriteLine($"Ending array: {string.Join(" ", arr2)}");

            int[] arr3 = { 3, 4, 10, 9, 1, 7, 8 };
            Console.WriteLine($"\nStarting array: {string.Join(" ", arr3)}");
            QuickSort(arr3, 0, arr3.Length - 1);
            Console.WriteLine($"Ending array: {string.Join(" ", arr3)}");

            int[] arr4 = { 6, 3, 1, 2 };
            Console.WriteLine($"\nStarting array: {string.Join(" ", arr4)}");
            QuickSort(arr4, 0, arr4.Length - 1);
            Console.WriteLine($"Ending array: {string.Join(" ", arr4)}");

            arr4 = null;
            Console.WriteLine("\nStarting array is null.");
            QuickSort(arr4, 0, 0);
            Console.WriteLine($"Ending array: {arr4}");

            Console.ReadKey();
        }

        private static void QuickSort(int[] arr, int startIndex, int endIndex)
        {
            // Check for null
            if (arr == null)
            {
                return;
            }

            // Base case
            if (endIndex <= startIndex)
            {
                return;
            }

            // Things we need
            int currentIndex = startIndex;
            int pivotWallIndex = startIndex;
            int pivotValue = arr[endIndex];

            // Partition
            while (currentIndex != endIndex)
            {
                // Compare currentIndex to pivotValue
                if (arr[currentIndex] <= pivotValue)
                {
                    Swap(arr, pivotWallIndex, currentIndex);
                    ++pivotWallIndex;
                } 
                // else currentIndex is greater than pivotValue so do nothing

                ++currentIndex;
            }

            // Swap pivotWall for pivot
            Swap(arr, pivotWallIndex, endIndex);

            // Recurse left
            QuickSort(arr, startIndex, pivotWallIndex - 1);

            // Recurse right
            QuickSort(arr, pivotWallIndex + 1, endIndex);
        }

        private static void Swap(int[] arr, int leftIndex, int rightIndex)
        {
            int temp = arr[leftIndex];
            arr[leftIndex] = arr[rightIndex];
            arr[rightIndex] = temp;
        }
    }
}
