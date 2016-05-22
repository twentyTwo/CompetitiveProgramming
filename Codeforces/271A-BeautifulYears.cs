using System;
using System.Collections.Generic;
using System.Linq;

namespace _119A_Epic_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var year = int.Parse(Console.ReadLine()) + 1;; year++)
            {
                if (year.ToString().Distinct().Count() == 4)
                {
                    Console.WriteLine(year.ToString());
                    break;
                }
            }

        }
    }
}