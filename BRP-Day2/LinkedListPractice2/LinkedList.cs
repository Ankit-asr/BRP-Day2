using System;
namespace LinkedListPractice
{
    public class Node
    {
        public Node next;
        public int data;
    }

    public class LinkedList
    {
        public Node head;
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(int data)
        {
            Node toAdd = new Node();
            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }
        public void AddLast(int data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
        public void Search(int elementToBeSearched)
        {
            Node current = head;
            if (current == null)
            {
                Console.WriteLine("Empty List");
            }
            else
            {
                while (current != null)
                {
                    if (current.data == elementToBeSearched)
                    {
                        Console.WriteLine("Element " + current.data + " is found ");
                        current = current.next;
                        Console.WriteLine("Element after that is : " + current.data);
                    }
                    current = current.next;
                   
                }
            }
        }

        class Program
        {
            public static void Main()
            {
                Console.WriteLine("Add First ");
                LinkedList myList1 = new LinkedList();
                myList1.AddFirst(10);
                myList1.AddFirst(20);
                myList1.AddFirst(30);
                myList1.AddFirst(40);
                myList1.AddFirst(50);
                myList1.PrintList();
                Console.WriteLine();
                Console.WriteLine("Add Last:");
                LinkedList myList2 = new LinkedList();
                myList2.AddLast(100);
                myList2.AddLast(200);
                myList2.AddLast(300);
                myList2.PrintList();
                Console.WriteLine("Enter the element to be searched ");
                int element = Convert.ToInt32(Console.ReadLine());
                myList1.Search(element);
            }
        }
    }
}