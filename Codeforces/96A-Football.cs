using System;
using System.Collections.Generic;
using System.Linq;

namespace _96A__Football
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char ch = str[0];
            int count = 1;
            bool dan=false;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    count++;
                    if (count == 7)
                    {
                        dan = true;
                        break;
                    }
                }
                else
                {
                    ch = str[i];
                    count = 1;
                }
            }

            Console.WriteLine(dan ? "YES" : "NO");
        }
    }
}