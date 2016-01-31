using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.Algorithms
{
    public class InsertionSort
    {
        int[] arr = new int[] { 4, 5, 1, 3, 7, 2 };

        public void Run()
        {
            Console.Write("Original Array:");
            foreach(var item in arr)
                Console.Write(item);

            performQuickSort(arr);

            Console.WriteLine("");
            Console.WriteLine("New Array");
            foreach (var item in arr)
                Console.Write(item);

            return;
        }

        void performQuickSort(int[] arr)
        {
            //two pointers i & j;
            for(int i=1;i<arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j -1] > arr[j])
                    {
                        swap(arr, j-1, j);
                    }
                }
            }
        }

        void swap(int[] arr, int fromPosition, int toPosition)
        {
            var tmp = arr[fromPosition];
            arr[fromPosition] = arr[toPosition];
            arr[toPosition] = tmp;
        }
    }
}
