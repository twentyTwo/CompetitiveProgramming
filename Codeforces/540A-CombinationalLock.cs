using System;
using System.Linq;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var orig = Console.ReadLine();
            var scrooge = Console.ReadLine();
            int a, b, sa, sb, sum=0;

            for (int i = 0; i < N; i++)
            {
                a = Convert.ToInt32(orig[i]);
                b = Convert.ToInt32(scrooge[i]);

                if (a > b)
                {
                    sa = a - b;
                    sb = 10 + b - a;
                }
                else
                {
                    sa = 10+a - b;
                    sb = b - a;
                }

                sum+= sa > sb ? sb : sa;

            }

            Console.WriteLine(sum);         
        }
    }
}