using System;
using System.Linq;

namespace _158A___Next_Round
{
    class usingLinQ
    {
        static void Main()
        {
            int N = 0, K = 0;
            int[] numList;
            int Number;

            string[] str1 = Console.ReadLine().Split(' ');
            string[] str2 = Console.ReadLine().Split(' ');

            N = int.Parse(str1[0]);
            K = int.Parse(str1[1]);

            numList = new int[N];
            for (int i = 0; i < N; i++) numList[i] = int.Parse(str2[i]);

            Console.WriteLine(numList.Where(x=> x>= numList[K-1] && x>0).Count());
        }
    }
}
