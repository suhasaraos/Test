using DSAlgos.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.Puzzles
{
    /// <summary>
    ///   //Given a sorted array with unique int, write algo to create binary search tree with optimal height.
    ///EX: { 2,3,4,5,6,7,8 }
    /// </summary>
    public class CreateBSTUsingSortedArray
    {
        //Ans
        //         5
        //       3    7
        //      2 4  6 8

        //Find ele at length/2 (odd) and insert , call recursively left arry and right arr.
        // if length is 1 - insert, if lngth

        public void Run()
        {
            int[] inputArr = new[] { 2, 3, 4, 6, 7, 8 };
            var newTree = new BinarySearchTree<int>();

            InsertToTree(inputArr, newTree);                  
        }

        void InsertToTree(int[] arr, BinarySearchTree<int> tree)
        {
            if (arr.Length <= 0)
                return;

            int midLoc = arr.Length / 2;
            tree.Add(arr[midLoc]);
            if (midLoc == 0)
                return;

            int[] leftArray = new int[midLoc];
            for (int i=0; i< midLoc; i++)
            {
                leftArray[i] = arr[i];
            }
            InsertToTree(leftArray, tree);

            int[] rightArray = new int[arr.Length - (midLoc + 1)];
            for (int i=midLoc + 1; i<arr.Length; i++)
            {
                rightArray[i - (midLoc + 1)] = arr[i];
            }
            InsertToTree(rightArray, tree);
        }
    }
}
