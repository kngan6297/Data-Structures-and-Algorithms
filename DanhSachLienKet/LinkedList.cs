using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKet
{
    class DanhSachLienKet
    {
        static Node Head = null;
        static void Main(string[] args)
        {
            insertHead(1, null);
            insertHead(2, null);
            insertHead(3, null);
            insertHead(4, null);
            insertHead(5, null);
            insertHead(6, null);
            insertHead(7, null);
            insertHead(8, null);
            insertHead(9, null);
            insertHead(10, null);
            printList();
            searchList();
            printEven();
            printOdd();
        }
        static void insertHead(int new_data, Node next)
        {
            Node new_node = new Node(new_data, null);
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
            Console.WriteLine("Linked list is: ");
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
        }
        static void searchList()
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
        static void printEven()
        {
            Node p = Head;
            Console.WriteLine("Even is: ");
            while (p != null)
            {
                if(p.data % 2 == 0)
                Console.Write(p.data + " ");
                p = p.next;
            }
        }
        static void printOdd()
        {
            Node p = Head;
            Console.WriteLine("\nOdd is: ");
            while (p != null)
            {
                if (p.data % 2 != 0)
                Console.Write(p.data + " ");
                p = p.next;
            }
        }
    }
}