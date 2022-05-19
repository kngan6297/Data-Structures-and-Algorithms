using System;
class Fibonacci
{
    static void Main(string[] args)
    {
        int n = 9;
        Console.Write(Fibo(n));
    }
    static int Fibo(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
