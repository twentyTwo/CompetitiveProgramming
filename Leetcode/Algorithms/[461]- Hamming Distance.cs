public class Solution {
    public int HammingDistance(int x, int y) {
        int res = x ^ y;  
        int count = 0;  
        for (int i = 0; i < 32; i++) {  
            if ((res & 1) != 0)  
                count++;  
            res >>= 1;  
        }  
        return count;  
    }
}
