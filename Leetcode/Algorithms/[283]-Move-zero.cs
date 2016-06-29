public class Solution {
    public void MoveZeroes(int[] nums) {
        int nonZeroCounter=0;
        
        for(int i=0; i<nums.Length; i++){
            if(nums[i]!=0){
                nums[nonZeroCounter++] = nums[i];
            }
        }
        
        for(int i=nonZeroCounter;i<nums.Length; i++){
            nums[i]=0;
        }
    }
}
