using System;
using System.Linq;
using System.Collections.Generic;

namespace _158A___Next_Round
{
    class Program
    {
        static void Main()
        {
            int N=0, K=0, count=0;
            int [] numList;
            int Number;

            var str1 = Console.ReadLine().Split(' ');
            var str2 = Console.ReadLine().Split(' ');


            N = int.Parse(str1[0]);
            K = int.Parse(str1[1]);

            numList = new int[N];

            for (int i = 0; i < N; i++) numList[i] = int.Parse(str2[i]);

            for (int i = 0; i < N; i++)
            {
                if (numList[i] >= numList[K-1] && numList[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
