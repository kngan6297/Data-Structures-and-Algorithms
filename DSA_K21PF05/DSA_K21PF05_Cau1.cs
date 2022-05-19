using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_K21PF05
{
    class DSA_K21PF05_Cau1
    {
        static Node Head = null;
        static void Main(string[] args)
        {
            // 1a
            insertHead(Head, 100);
            insertHead(Head, 100);
            //1b
            Random rd = new Random();
            for (int i = 0; i < 8; i++)
            {
                int rand_num = rd.Next(100, 200);
                insertHead(Head, rand_num); 
            }           
            printList();
            //1c
            search(Head);
            // 1d
            max(Head);
            // 1e
            delete(Head);
        }
        static void insertHead(Node head, int data)
        {
            Node new_node = new Node(data);
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
        static void search(Node head)
        {
            Console.WriteLine("\nInput number to search: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Node s = Head;
            bool logic = false;
            while (s != null)
            {
                if (s.data != n)
                {
                    s = s.next;
                }
                else
                {
                    logic = true;
                    s = null;
                }
            }
            if (logic == true) Console.WriteLine("Exist!");
            else Console.WriteLine("No exist!");
        }
        static void max(Node head)
        {
            int max = Head.data;
            Node q = Head;
            while (q != null)
            {
                if (max < q.data) max = q.data;
                q = q.next;
            }
            Console.WriteLine("Max value is: " + max);
        }
        static void delete(Node head)
        {
            Console.WriteLine("\nInput number to delete: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Node s = Head;
            bool logic = false;
            int position = 0;
            while (s != null)
            {
                if (s.data != k)
                {
                    s = s.next;
                    position++;
                }
                else
                {
                    logic = true;
                    deleteInPosition(position+1);
                    s = s.next;
                }
            }
            if (logic != true) Console.WriteLine("No x to delete!");
            else Console.WriteLine("\nLinked list after delete x is: ");
            printList();
        }

        static void deleteInPosition(int position)
        {
            if (position < 1)
            {
                Console.Write("\nPosition should be >= 1.");
            }
            else if (position == 1 && Head != null)
            {
                Node nodeToDelete = Head;
                Head = Head.next;
                nodeToDelete = null;
            }
            else
            {
                Node temp = new Node(Head);
                temp = Head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null && temp.next != null)
                {
                    Node nodeToDelete = temp.next;
                    temp.next = temp.next.next;
                    nodeToDelete = null;
                }
                else
                {
                    Console.Write("\nThe node is already null.");
                    return;
                }
            }
        }
    }
}