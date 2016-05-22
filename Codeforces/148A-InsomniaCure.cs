using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _148A_Insomnia_Cure
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int [] divisor = new int[4];
            for (int i = 0; i < 4; i++)
            {
                divisor[i] = int.Parse(Console.ReadLine());
            }
            Int64 d = Int64.Parse(Console.ReadLine());

            int [] numbers = new int[d];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 0;
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    if ((j + 1) % divisor[i] == 0 && numbers[j] == 0)
                    {
                        numbers[j] = 1;
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}