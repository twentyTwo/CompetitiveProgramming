using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131A_CapsLock
{
    static class Program
    {
        public static bool IsAllUppercase(this string str, int start)
        {
            int i = 0;
            for (i = start; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z') return false;                
            }
            return true;
        }

        static void PrintAllLowercase(this string str, int start)
        {
            int i = 0;
            char ch;
            for (i = start; i < str.Length; i++)
            {
                Console.Write(char.ToLower(str[i]));
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            int i = 0;
            string str = Console.ReadLine();
            char ch;

            if (str.Length==1)
            {
                if (str[0] >= 'a' && str[0] <= 'z')
                {
                    ch = char.ToUpper(str[0]);
                    Console.WriteLine(ch);
                }
                else
                {
                    ch = char.ToLower(str[0]);
                    Console.WriteLine(ch);
                }
                
            }

            else if (str.IsAllUppercase(0))
            {
                str.PrintAllLowercase(0);
            }

            else if (str[0] >= 'a' && str[0] <= 'z' && str.IsAllUppercase(1))
            {
                ch = char.ToUpper(str[0]);
                Console.Write(ch);
                str.PrintAllLowercase(1);
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
