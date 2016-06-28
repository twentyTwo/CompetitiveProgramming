public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var container = new HashSet<int>();

            foreach (var n in nums)
            {
                if (container.Contains(n))
                {
                    return true;
                }

                container.Add(n);
            }

            return false;
    }
}
