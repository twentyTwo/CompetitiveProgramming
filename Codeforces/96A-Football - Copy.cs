using System;
using System.Linq;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var val = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(val);
            foreach (var x in val)
            {
                Console.Write("{0} ",x);
            }
            Console.WriteLine();            
        }
    }
}