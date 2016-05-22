using System;
using System.Collections.Generic;
using System.Linq;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int even=0, odd=0;

            var str = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int evenCount = str.Count(x => x%2 == 0);

            if (evenCount == 1)
            {
                for (int i = 0; i < N; i++)
                {
                    if (str[i]%2 == 0)
                    {
                        Console.WriteLine(i+1);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    if (str[i] % 2 == 1)
                    {
                        Console.WriteLine(i+1);
                        break;
                    }
                }
            }

        }
    }
}