public class Solution {
    public int RemoveDuplicates(int[] nums) {
        // Here count the distinct number only  will not get accepted, need to arrange the duplicate numbers in sequence. 
         
        if (nums.Length==0) return 0;
        int j = 0;

        for(int i = 1; i < nums.Length; ++i) {
            if (nums[i] != nums[j])
            {
                nums[++j] = nums[i];
            }
               
        }
        return j+1;
    }
}
