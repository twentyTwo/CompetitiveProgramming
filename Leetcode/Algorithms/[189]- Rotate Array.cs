public class Solution {
    public void Rotate(int[] nums, int k) {
            
            var queue = new Queue<int>();

            for (var i = nums.Length - 1; i >= 0; i--)
            {
                queue.Enqueue(nums[i]);
            }

            for (var i = 0; i < k; i++)
            {
                var a = queue.Dequeue();
                queue.Enqueue(a);
            }


            for (var i = nums.Length - 1; i >= 0; i--)
            {
                nums[i] = queue.Dequeue();
            }
    }
}
