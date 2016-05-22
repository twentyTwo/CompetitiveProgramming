
namespace _339A_Helpful_Math
{
    using System;

    /// <summary>
    ///     The program.
    /// </summary>
    class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split('+');
            Array.Sort(numbers);
            Console.Write(numbers[0]);

            for (var i = 1; i < numbers.Length; i++)
            {
                Console.Write("+{0}", numbers[i]);
            }

            Console.Write("\n");
        }
    }
}
