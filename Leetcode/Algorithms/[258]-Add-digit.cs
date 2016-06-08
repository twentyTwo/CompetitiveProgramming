public class Solution {
    public int AddDigits(int num) {
            int full = (num/9)*9;
            int ans = num>0 ? (num == full ? 9 : num - full) : 0;
        return ans; 
    }
}
