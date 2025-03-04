using System;
using System.Collections.Generic;
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
            Head.Next = Tail;

        }
        public int Count { get; set; }

        public void AddFirst(Node<T> node)
        {
            Node<T> temp = Head;

            Head = node;

            Head.Next = temp;

            Count++;
        }
        public T GetFirst()
        {
            return Head.Value;
        }
    }
}
