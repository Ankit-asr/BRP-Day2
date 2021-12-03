using System;

namespace LinkedListPractice
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int i)
        {
            data = i;
            next = null;
        }
        public void Print()
        {
            Console.Write(" | " + data + " |->");
            if (next != null)
            {
                next.Print();
            }
        }
        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Node myNode = new Node(1);
            myNode.AddToEnd(2);
            myNode.AddToEnd(3);
            myNode.AddToEnd(4);
            myNode.AddToEnd(5);
            myNode.Print();
        }
    }
}
