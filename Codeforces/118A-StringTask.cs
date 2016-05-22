using System;

namespace codeforces
{
    class Program
    {
        static bool isContainsVowels(char ch)
        {
            char[] skipLetter = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < 6; i++) if (ch == skipLetter[i]) return true;
            return false;
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int i=0, j=0, l = word.Length;
           
            for (i = 0; i < l; i++)
            {
                if (!isContainsVowels(word[i]))
                {
                    Console.Write("."+word[i]);
                }           
            }
            Console.Write("\n");
        }
    }
}
