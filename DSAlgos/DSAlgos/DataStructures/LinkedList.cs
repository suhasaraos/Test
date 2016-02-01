using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.DataStructures
{
    public class LinkedList
    {

        public void Run()
        {
            SinglyLinkedList<int> demoSingleLinkedList = new SinglyLinkedList<int>();
            demoSingleLinkedList.Add(5);
            demoSingleLinkedList.Add(3);
            demoSingleLinkedList.Add(7);
            demoSingleLinkedList.Add(9);
            demoSingleLinkedList.Remove(3);
        }
    }

    public class SinglyLinkedList<T> where T : IComparable
    {
        public SinglyLinkedListNode<T> Head { private set; get; }

        public SinglyLinkedListNode<T> Tail { private set; get; }

        public void Add(T data)
        {
            if(Head == null)
            {
                Head = Tail = new SinglyLinkedListNode<T>(data);
            }
            else
            {
                Tail.Next = new SinglyLinkedListNode<T>(data);
                Tail = Tail.Next;
            }
        }

        public void Remove(T data)
        {
            var current = Head;
            var previous = Head;

            while (current != null)
            {
                if(current.Value.CompareTo(data) == 0) //Match found
                {
                    if(current == previous)
                    {
                        Head = Tail = null;
                    }
                    else
                    {
                        previous.Next = current.Next;
                        return;
                    }
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }
        }        
    }

    public class SinglyLinkedListNode<T> where T : IComparable
    {
        public SinglyLinkedListNode(T data)
        {
            Value = data;
        }
        public T Value { get; set; }

        public SinglyLinkedListNode<T> Next { get; set; }
    }
}
