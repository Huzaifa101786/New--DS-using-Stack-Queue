using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Stack_Queue_DS
{ 
    internal class LinkedList
    {
        Node head = null;
        class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }

        }

        public void InsertAtLast(int value)
        {
            Node n_node = new Node(value);
            Node temp = head;
            if (head == null)
            {
                head = n_node;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = n_node;
            }

        }
        
        public void RemoveLast()
        {
            Node temp = head;

            if (temp != null)
            {
                if(temp.next == null)
                {
                    Console.WriteLine("\nOnly 1 value found and removed");
                    temp = null;
                    return;
                }
                while(temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("Last value removed");
            }
            else
            {
                Console.WriteLine("list is Empty");
            }
        }

        public void RemoveFirst()
        {
            Node temp = head;
            head = head.next;
            Console.WriteLine("Removing First value");
            Console.WriteLine("First value removed");
        }


        public void PrintList()
        {
            Node n = head;
            if (head == null)
            {
                Console.Write("List is empty");
            }
            Console.Write("Values in Linked List are : ");
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }

        }

        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("---STACK QUEUE IMPLEMENTATION---\n");

            Again:
            Console.WriteLine("Enter 1 to add value");
            Console.WriteLine("Enter 2 to remove last value");
            Console.WriteLine("Enter 3 to remove 1st value");
            Console.Write("Choose option from 1 to 3 : ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Enter value that to want to add : ");
                    int value = int.Parse(Console.ReadLine());
                    list.InsertAtLast(value);
                    list.PrintList();
                    Console.WriteLine("\n\nWant to do another operation? Y/N");
                    string x = Console.ReadLine();
                    if(x == "Y" || x == "y")
                    {
                        goto Again;
                    }
                    
                    break;
                    
                case 2:
                    Console.WriteLine("Removing last value from list");
                    list.RemoveLast();
                    list.PrintList();
                    Console.WriteLine("\n\nWant to do another operation? Y/N");
                    string s = Console.ReadLine();
                    if (s == "Y" || s == "y")
                    {
                        goto Again;
                    }
                    break;
                case 3:
                    Console.WriteLine("Removing 1st value from list");
                    list.RemoveFirst();
                    list.PrintList();
                    Console.WriteLine("\n\nWant to do another operation? Y/N");
                    string z = Console.ReadLine();
                    if (z == "Y" || z == "y")
                    {
                        goto Again;
                    }
                    break;
            }

            list.PrintList();
            list.RemoveLast();
            list.PrintList();
            Console.ReadKey();
         
        }
    }
}




