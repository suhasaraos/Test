using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.Puzzles
{
    public class RotatedArray
    {
        public void Run()
        {
            int[] array = new int[] { 12, 13, 17, 56, 3, 5, 9, 11 };
            FindElementRotatedArray(array, 11, 0, array.Length - 1);
        }

        /// <summary>
        /// Assumes no duplicates
        /// </summary>
        void FindElementRotatedArray(int[] array, int searchElement, int startIndex, int endIndex)
        {
            if (endIndex < startIndex)
                return; //Element not found  

            int mid = (startIndex + endIndex) / 2;

            //Compare first element and last element in array to see if its sorted             
            if (array[startIndex] <= array[endIndex])
            {
                //Regular Binary search       
                if (array[mid] < searchElement)   //Search right side
                {
                    FindElementRotatedArray(array, searchElement, mid + 1, endIndex);
                }
                else
                {
                    FindElementRotatedArray(array, searchElement, startIndex, mid - 1);
                }                       
                if (array[mid] == searchElement)
                {
                    Console.WriteLine("Element found at position:" + mid);
                    return;
                }                             
            }
            //If rotated
            else
            {
                FindElementRotatedArray(array, searchElement, startIndex, mid);
                FindElementRotatedArray(array, searchElement, mid + 1, endIndex);
            }

        }


    }
}
