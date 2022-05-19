using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DSA_K21PF05
{
    class DSA_K21PF05_Cau2
    {
        static Node Head = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of list: ");
            int total = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("\nInput number to add: ");
                int n = Convert.ToInt32(Console.ReadLine());
                insertHead(Head, n);
            }
            Console.WriteLine("\nReverse linked list is: ");
            printList();
        }
        static void insertHead(Node head, int data)
        {
            Node new_node = new Node(data, null);
            if (Head == null)
            {
                Head = new_node;
            }
            else
            {
                new_node.next = Head;
                Head = new_node;
            }
        }
        static void printList()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
        }

        static void ReverseList()
        {
            Node prev = null, current = Head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            Head = prev;
            printList();
        }
    }
}