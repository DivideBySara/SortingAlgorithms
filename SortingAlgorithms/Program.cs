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

            int[] arr = { 3, 4, 1, 2 };
            Console.WriteLine($"\nStarting array: {string.Join(" ", arr)}");

            arr = QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine($"\nEnding array: {string.Join(" ", arr)}");

            Console.ReadKey();
        }

        private static int[] QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int partition = Partition(arr, leftIndex, rightIndex);

                arr = QuickSort(arr, 0, rightIndex);
                arr = QuickSort(arr, rightIndex + 1, arr.Length - 1);
            }

            return arr;
        }

        private static int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            // Choose a pivot value
            int pivotValue = arr[leftIndex];
            int small = leftIndex - 1;

            for (int i = leftIndex; i < rightIndex; ++i)
            {
                if (arr[i] < pivotValue)
                {
                    ++small;
                    Swap(arr, i, small);
                }
            }

            Swap(arr, rightIndex, small + 1);

            return small + 1;
        }

        private static void Swap(int[] arr, int leftIndex, int rightIndex)
        {
            int temp = arr[leftIndex];
            arr[leftIndex] = arr[rightIndex];
            arr[rightIndex] = arr[leftIndex];
        }
    }
}
