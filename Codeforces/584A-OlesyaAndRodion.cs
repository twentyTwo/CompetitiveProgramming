sing System;
using System.Linq;

namespace Codeforces
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (nums[1] == 10)
            {
                if (nums[0] == 1)
                {
                    Console.Write("-1");
                }
                else
                {
                    Console.Write("1");
                    for (int i = 1; i < nums[0]; i++)
                    {
                        Console.Write("0");
                    } 
                }
                
            }
            else
            {
                for (int i = 0; i < nums[0]; i++)
                {
                    Console.Write(nums[1].ToString());
                }
            }
            Console.WriteLine();
        }
    }
}