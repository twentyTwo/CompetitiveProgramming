public class Solution {
    public int TrailingZeroes(int n) {
            int sum = 0;
            while (n >= 5)
            {
                n /= 5;
                sum += n;
            }
            return sum;
    }
}
