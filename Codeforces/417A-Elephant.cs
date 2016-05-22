using System;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(N / 5 + (N % 5 == 0 ? 0 : 1));
        }
    }
}