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
            Console.WriteLine("\nStarting array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            arr = QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("\n\nEnding array: ");

            Console.ReadKey();
        }

        private static int[] QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            throw new NotImplementedException();
        }
    }
}
