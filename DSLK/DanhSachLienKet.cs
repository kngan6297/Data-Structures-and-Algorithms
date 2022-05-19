using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK
{
    class DanhSachLienKet
    {
        static Node Head = null;
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("\n-----Menu-----");
                Console.WriteLine("1. Tao danh sach");
                Console.WriteLine("2. Duyet danh sach");
                Console.WriteLine("3. Them phan tu x vao danh sach");
                Console.WriteLine("4. Xoa phan tu dau danh sach");
                Console.WriteLine("5. Xoa phan tu x ra khoi danh sach");
                Console.WriteLine("6. Tim kiem mot phan tu x tren danh sach");
                Console.WriteLine("7. Tim phan tu lon nhat");
                Console.WriteLine("8. Thoat");
                Console.WriteLine("--------------");
                Console.WriteLine("Chon menu: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    insertHead(5, null);
                    insertHead(7, null);
                    insertHead(9, null);
                    insertHead(15, null);
                    insertHead(11, null);
                    printList();
                }
                else if (n == 2) printList();
                else if (n == 3) printList();
                else if (n == 4) deleteHead();
                else if (n == 5) deleteX();
                else if (n == 6) searchList();
                else if (n == 7) searchMax();
                else if (n == 8) return;
            } while (n < 8);            
        }
        static void insertHead(int new_data, Node next)
        {
            Node new_node = new Node(new_data, null);
            if(Head == null)
            {
                Head = new_node;
            }
            else
            {
                new_node.next = Head;
                Head = new_node;
            }            
        }
        static void insertMid(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node"
                                  + " cannot be null");
                return;
            }
            Node new_node = new Node(new_data, null);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }
        static void insertEnd(int new_data)
        {
            Node new_node = new Node(new_data, null);
            if (Head == null)
            {
                Head = new Node(new_data, null);
                return;
            }
            new_node.next = null;
            Node last = Head;
            while (last.next != null)
                last = last.next;
            last.next = new_node;
            return;
        }
        //Traversal
        static void printList()
        {
            Node p = Head;
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
            if(logic == true) Console.WriteLine("Exist!");
            else Console.WriteLine("No exist!");
        }
        static void searchMax()
        {
            int max = Head.data;
            Node q = Head;
            while (q != null)
            {
                if(max < q.data) max = q.data;
                q = q.next;
            }
            Console.WriteLine("Max value is: " + max);
        }
        static void deleteHead()
        {
            if(Head == null)
            {
                Console.WriteLine("Nothing to delete!");
            }
            else
            {
                Head = Head.next;
            }
            Console.WriteLine("\nLinked list after delete Head is: ");
            printList();
        }
        static void deleteX()
        {
            if (Head == null || Head.next == null)
            {
                deleteHead();
            }
            else
            {
                Console.WriteLine("\nInput number to delete: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Node s = Head;
                bool logic = false;
                while (x != null)
                {
                    if (s.data != x)
                    {
                        s = s.next;                        
                    }
                    else
                    {
                        logic = true;
                        s = null;
                    }
                }
                if (logic == true) Console.WriteLine("No x to delete!");
                else Console.WriteLine("\nLinked list after delete x is: ");
                printList();
            }            
        }
    }
}
