using System;

using System.Linq;


namespace _155A__I_love_username
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int min = 0, max = 0, count = 0, i = 0;
            int[] str = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            min = max = str[0];
            for (i=1 ;  i< N; i++)
            {
                if (str[i] < min)
                {
                    min = str[i];
                    count++;
                }
                if (str[i] > max)
                {
                    max = str[i];
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
