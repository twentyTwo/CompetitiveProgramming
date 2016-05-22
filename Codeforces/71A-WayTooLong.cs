using System;

namespace codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, N = int.Parse(Console.ReadLine());
            string str;
            while (N-->0)
            {
                str = Console.ReadLine();
                l = str.Length;
                Console.WriteLine(l > 10 ? str[0] + (l - 2).ToString() + str[l - 1] : str);
            }
        }
    }
}
