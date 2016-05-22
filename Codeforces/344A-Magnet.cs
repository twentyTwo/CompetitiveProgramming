using System;
using System.Linq;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string curMag, prevMag=String.Empty;
            int count = 0;

            while (N-- > 0)
            {
                curMag = Console.ReadLine();
                if (curMag != prevMag)
                {
                    count++;
                }

                prevMag = curMag;
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
        
    }
}