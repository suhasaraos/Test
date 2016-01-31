using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.DataStructures
{
    public class Tree
    {
        public void Run()
        {
            BinarySearchTree<int> newTree = new BinarySearchTree<int>();
            newTree.Add(7);
            newTree.Add(8);
            newTree.Add(5);
            newTree.Add(6);
            newTree.Add(14);
            newTree.Add(11);
            newTree.Add(9);
            newTree.Add(12);
            newTree.Add(10);

            newTree.Add(17);

            Console.Write("Preorder: ");
            PreOrderTraversal(newTree.Root);

            Console.Write(Environment.NewLine + "Inorder: ");
            InorderTraversal(newTree.Root);

            Console.Write(Environment.NewLine + "Postorder: ");
            PostOrderTraversal(newTree.Root);
        }

        void PreOrderTraversal(BinaryTreeNode<int> treeNode)
        {
            Console.Write(treeNode.Value + ",");
            if (treeNode.Left != null)
                InorderTraversal(treeNode.Left);

            if (treeNode.Right != null)
                InorderTraversal(treeNode.Right);
        }

        void InorderTraversal(BinaryTreeNode<int> treeNode)
        {            
            if(treeNode.Left !=null)
                InorderTraversal(treeNode.Left);
            Console.Write(treeNode.Value + ",");

            if (treeNode.Right !=null)
                InorderTraversal(treeNode.Right);
        }               

        void PostOrderTraversal(BinaryTreeNode<int> treeNode)
        {            
            if (treeNode.Left != null)
                InorderTraversal(treeNode.Left);

            if (treeNode.Right != null)
                InorderTraversal(treeNode.Right);
            Console.Write(treeNode.Value + ",");
        }

    }

    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinaryTreeNode<T> Root { private set; get; }        

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Clear()
        {
            Root = null;
        }

        public void Add(T data)
        {
            var newNode = new BinaryTreeNode<T>(data);
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            var current = Root;
            BinaryTreeNode<T> parent = null;

            while (current != null)
            {
                var result = current.Value.CompareTo(newNode.Value);

                if(result == 0) //both values are same
                {
                    return; //attempting to enter duplicate :)
                }
                else if(result > 0)
                {
                    if (current.Left != null)
                    {
                        parent = current;
                        current = current.Left;
                    }
                    else
                    {
                        current.Left = newNode;
                        return;
                    }
                }
                else if(result < 0)
                {
                    if (current.Right != null)
                    {
                        parent = current;
                        current = current.Right;
                    }
                    else
                    {
                        current.Right = newNode;
                        return;
                    }
                }                
            }            
        }
    }

    public class BinaryTreeNode<T> where T : IComparable<T>
    {
        public BinaryTreeNode(T Value)
        {
            this.Value = Value;
        }
        public T Value { get; set; }

        public BinaryTreeNode<T> Left { get; set; }

        public BinaryTreeNode<T> Right { get; set; }
    }
}

