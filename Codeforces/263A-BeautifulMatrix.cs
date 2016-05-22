using System;
using System.Collections.Generic;
using System.Linq;

namespace _263A_Beautiful_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                var s = Console.ReadLine().Split(' ');
                for (int j = 1; j <= 5; j++)
                {
                    if (s[j - 1] == "1")
                    {
                        var result = Math.Abs(i - 3) + Math.Abs(j - 3);
                        Console.WriteLine(result);
                    }
                }
            }
            
        }
    }
}