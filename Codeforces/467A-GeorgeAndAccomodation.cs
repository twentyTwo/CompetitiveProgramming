using System;
using System.Collections.Generic;
using System.Linq;

namespace _467A_George_and_Accommodation
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine()), count=0;
            while (n-->0)
            {
                var numbers = Console.ReadLine().Split(' ').ToArray();
                if (int.Parse(numbers[0])+2 <= int.Parse(numbers[1]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}