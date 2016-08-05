public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        
            HashSet<int> numSet1 = new HashSet<int>();
            HashSet<int> numSet2 = new HashSet<int>();

            foreach (var x in nums1) numSet1.Add(x);
            foreach (var x in nums2) numSet2.Add(x);

            var minSet = numSet1.Count() <= numSet2.Count() ? numSet1 : numSet2;
            var maxSet = numSet1.Count() > numSet2.Count() ? numSet1 : numSet2;

            return minSet.Where(n => maxSet.Contains(n)).ToArray();
    }
}
