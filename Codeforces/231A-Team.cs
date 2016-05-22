using System;

namespace _231A___Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int S=0, R=0, N = int.Parse(Console.ReadLine());
            string [] str;

            while (N-- > 0)
            {
                S = 0;
                str =  Console.ReadLine().Split(' ');
                S = int.Parse(str[0]) + int.Parse(str[1]) + int.Parse(str[2]);
                if (S > 1) R = R + 1;
            }
            Console.WriteLine(R);
        }
    }
}
