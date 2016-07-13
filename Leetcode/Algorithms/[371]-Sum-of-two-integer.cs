public class Solution {
    public int GetSum(int a, int b) {
        if(a==0) return b;
        return GetSum((a & b) << 1, a^b);
    }
}
