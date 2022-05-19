using System;
class PrintNumbers
{
    static void Main(string[] args)
    {
        Print(1);
    }
    static void Print(int n)
    {
        if (n == 101) return;
        else
        {
            Console.Write(" " + n);
            Print(n + 1);
        }
        
    }
}