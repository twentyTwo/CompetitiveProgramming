public class Solution {
    public int ClimbStairs(int n) {
        List<int> ways = new List<int>();
        ways.Add(1);
        ways.Add(2);
        for(int i=2; i<=n; i++){
            ways.Add(ways[i-1]+ways[i-2]);
        }
        return ways[n-1];
    }
}
