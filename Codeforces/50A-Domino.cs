using System;
using System.Linq;

namespace _50A__Domino
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = Console.ReadLine().Split(' ').Select(int.Parse).Aggregate((a,b)=>a*b);
            Console.WriteLine(r/2);
        }
    }
}
