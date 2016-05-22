using System;
using System.Collections.Generic;
using System.Linq;

namespace _208A_Dubstep
{
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Solution2();
        }

        static void Solution1()
        {
            Console.WriteLine(Console.ReadLine().Split(new []{"WUB"}, StringSplitOptions.RemoveEmptyEntries));
        }

        static void Solution2()
        {
            string str = Console.ReadLine();
            Console.WriteLine(str.Replace("WUB", " ").Trim());
        }
    }
}