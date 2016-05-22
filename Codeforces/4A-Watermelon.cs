using System;
class Program
{
    static void Main(string[] args)
    {
        byte N = Byte.Parse(Console.ReadLine());
        Console.WriteLine((N % 2 == 0 && N != 2) ? "YES" : "NO");
    }
}
