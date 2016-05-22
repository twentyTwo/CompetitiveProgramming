using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _486A_Calculating_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Int64.Parse(Console.ReadLine());
            long evenNums, oddNums;
            evenNums = n / 2;
            oddNums = n - evenNums;
            Console.WriteLine(evenNums * (evenNums+1)-oddNums*oddNums);
        }
    }
}