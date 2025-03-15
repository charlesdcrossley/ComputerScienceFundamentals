using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class SinglyLinkedList<T>
    {
        public Node<T>? Head { get; set; } 
        public Node<T>? Tail { get; set; }

        public SinglyLinkedList()
        {
                Head = new Node<T>(default);
                Tail = new Node<T>(default);
            
        }
        public int Count { get; set; }

        public void InsertFirst(Node<T> node)
        {
            if (Head.Next == null)
                Tail = node;

            Node<T> temp = Head;
            Head = node;
            Head.Next = temp;

            Count++;

        
        }
        public void InsertLast(Node<T> node)
        {            
            Node<T> temp = Tail;

            temp.Next = node;

            Tail = node;

            
                    }
        public T GetFirst()
        {
            return Head.Value;
        }
        public T GetLast()
        {
            return Tail.Value;
        }
        public void DisplayListConsole(bool debugFlag = false)
        {
            Node<T> node = Head;

            do
            {
                switch (debugFlag)
                {
                    case false:
                        Console.WriteLine(node.Value);
                        break;
                    case true:
                        Debug.WriteLine(node.Value);
                        break;
                }
                node = node.Next;
            }
            while (node.Next != null);            
        }
    }
}
