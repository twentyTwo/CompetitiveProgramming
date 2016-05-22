using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _451A_Game_With_Sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var min = a[0] > a[1] ? a[1] : a[0];
            Console.WriteLine(min % 2 == 0 ? "Malvika" : "Akshat");

        }
    }
}