using System;
using System.Collections.Generic;
using System.Linq;

namespace _546A_Soldier_and_Bananas
{
    using System.Diagnostics.CodeAnalysis;

    class Program
    {
        static void Main(string[] args)
        {
            int [] N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long sum = N[0] * (N[2] * (N[2] + 1) / 2); 
            Console.WriteLine(sum > N[1] ? sum - N[1] : 0);
        }
    }
}