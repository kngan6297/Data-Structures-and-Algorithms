using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_K21PF05
{
    class Node
    {
        public int data;
        public Node next;
        public Node (int k)
        {
            data = k;
        }

        public Node(Node node)
        {
            next = node;
        }
    }
}
