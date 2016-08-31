/*O(n) Time complexity: Accepted */

public class Solution {
    public int FirstUniqChar(string s) {
            int[,] matrix = new int[26, 2];
            int index = 0;
            int small = int.MaxValue;

            matrix.Initialize();

            foreach (var letter in s)
            {
                var i = letter - 'a';
                matrix[i, 0]++;
                matrix[i, 1] = index++;
            }

            for (var i = 0; i < 26; i++)
            {
                if (matrix[i, 0] != 1)
                {
                    continue;
                }

                if (matrix[i, 1] < small)
                {
                    small = matrix[i, 1];
                }
            }

            if (small == int.MaxValue)
            {
                return -1;
            }

            return small;
    }
}
