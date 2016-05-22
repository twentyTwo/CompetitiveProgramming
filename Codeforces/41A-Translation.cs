using System;
using System.Collections.Generic;
using System.Linq;

namespace _41A_Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isReverse = true;
            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            int j = 0;
            if (str1.Length != str2.Length)
            {
                isReverse = false;
            }
            else
            {
                for (int i = str1.Length - 1; i >= 0; i--)
                {
                    if (str1[i] != str2[j++])
                    {
                        isReverse = false;
                    }
                } 
            }
            
            Console.WriteLine(isReverse ? "YES" : "NO");
        }
    }
}