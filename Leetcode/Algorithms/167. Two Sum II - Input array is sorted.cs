public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var p1 = 0;
        var p2 = numbers.Length - 1;

        while (numbers[p1] + numbers[p2] != target)
        {
            if (numbers[p1] + numbers[p2] < target)
            {
                p1++;
            }
            else if (numbers[p1] + numbers[p2] > target)
            {
                p2--;
            }
        }
         return new[] { p1+1, p2+1 }; 
    }
}
