using System;
using System.Collections.Generic;
using System.Linq;

namespace _82A_Double_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            Int32 n = Int32.Parse(Console.ReadLine());
            n -= 1;
            while (n >= 5)
            {
                n -= 5;
                n /= 2;
            }

            Console.WriteLine(names[n]);
        }
    }
}