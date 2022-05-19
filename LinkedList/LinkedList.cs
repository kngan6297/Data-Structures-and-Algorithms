namespace LinkedList
{
    class LinkedList
    {
        static Node Head = null;
        static void Main(string[] args)
        {
            Node node8 = new Node(8, null);
            Node Head = node8;

            Node node7 = new Node(7, null);
            node7.next = Head;
            Head = node7;

            Node node4 = new Node(4, null);
            node4.next = Head;
            Head = node4;

            Node node3 = new Node(3, null);
            node3.next = Head;
            Head = node3;

            Node node9 = new Node(9, null);
            node9.next = Head;
            Head = node9;

            var p = Head;
            while (p != null)
            {
                Console.WriteLine(p.data);
                p = p.next;
            }

            var sum = 0;
            p = Head;
            while (p != null)
            {
                sum += p.data;
                p = p.next;
            }
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
