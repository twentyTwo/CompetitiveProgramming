using System;
using System.Collections.Generic;
using System.Linq;

namespace _160A_Twins
{
    class Program
    {
        static void Main(string[] args)
        {
            int take = 0, i=0;
            Console.ReadLine();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();
            while (take <= numbers.Sum() / 2)
            {
                take += numbers[i];
                i++;
            }
            Console.WriteLine(i);
        }
    }
}