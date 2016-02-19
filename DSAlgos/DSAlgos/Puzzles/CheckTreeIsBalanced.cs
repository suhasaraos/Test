using DSAlgos.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.Puzzles
{
    public class CheckTreeIsBalanced
    {

        /// <summary>
        /// To check if give tree is balanced
        /// </summary>
        public void Run()
        {

            BinarySearchTree<int> newTreeUnbalanced = new BinarySearchTree<int>();
            newTreeUnbalanced.Add(7);
            newTreeUnbalanced.Add(8);
            newTreeUnbalanced.Add(5);
            newTreeUnbalanced.Add(6);
            newTreeUnbalanced.Add(14);
            newTreeUnbalanced.Add(11);
            newTreeUnbalanced.Add(9);
            newTreeUnbalanced.Add(12);
            newTreeUnbalanced.Add(10);
            newTreeUnbalanced.Add(17);
              //             7
              //        5         8
              //      x   6      x   14
              //         x  x      11  17
              //                9    12
              //               x  10

            VisitNode(newTreeUnbalanced.Root);
        }

        ////Algo
        //      5
        //   3     7
        // 1   4  6  8

        int VisitNode(BinaryTreeNode<int> treeNode)
        {
            int leftVal = 0, rightVal = 0;
            if(treeNode.Left == null)
            {
                leftVal = -1;
            }
            else
            {
                leftVal = VisitNode(treeNode.Left);
            }
            if(treeNode.Right == null)
            {
                rightVal = -1;
            }
            else
            {
                rightVal = VisitNode(treeNode.Right);
            }

            if(Math.Abs(leftVal - rightVal) > 1)
            {
                Console.WriteLine("Tree is not balanced");
            }

            return (leftVal > rightVal ? leftVal : rightVal) + 1;
        }
     }
}
