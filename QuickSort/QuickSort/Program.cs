using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace QuickSort
{
    class Program
    {
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11 };
            Console.WriteLine("Mang ban đau:");
            PrintArray(arr);

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Mang sau khi sap xep:");
            PrintArray(arr);
            Console.ReadKey();
        }
    }
}
