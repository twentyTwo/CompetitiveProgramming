    public int[] Intersect(int[] nums1, int[] nums2) {
            var small = nums1.Length < nums2.Length ? nums1.ToList() : nums2.ToList();
            var big = nums1.Length < nums2.Length ? nums2.ToList() : nums1.ToList();
            var ans = new List<int>();

            foreach (var e in small)
            {
                if (big.Contains(e))
                {
                  ans.Add(e);  
                  big.RemoveAt(big.IndexOf(e));
                }
            }
            return ans.ToArray();
    }
