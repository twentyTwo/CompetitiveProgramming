using System;
using System.Collections.Generic;
using System.Linq;

namespace _460A_Vasya_and_Socks
{
    using System.Diagnostics.CodeAnalysis;

    class Program
    {
        static void Main(string[] args)
        {
           float [] n =  Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
            float sum = 0;
            sum += n[0];

            while ((n[0] / (n[1] * 1.0)) >= 0.001)
            {
                n[0] = (float)(n[0] / (n[1] * 1.0));
                sum += n[0];
            }
            Console.WriteLine((int)sum);
        }
    }
}