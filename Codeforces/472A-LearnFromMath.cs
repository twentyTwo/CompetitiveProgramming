using System;
using System.Collections.Generic;
using System.Linq;


namespace _472A_Design_From_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 = 2+2 and 9 = 3+3+3
            int n= int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} {1}", 4, n -4);
            }
            else
            {
                Console.WriteLine("{0} {1}", 9, n-9);
            }
        }
    }
}