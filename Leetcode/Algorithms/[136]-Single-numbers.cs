public class Solution {
    public int SingleNumber(int[] nums) {
        int res=0;
        for(int i=0; i<nums.Length; i++){
            // X^X = 0, X^0 = X Where X is an integer
            res^=nums[i];
        }
        return res;
    }
}
