public class Solution {
    public int CompareVersion(string version1, string version2) {
            int i;
            var first = version1.Split('.').Select(int.Parse).ToArray();
            var second = version2.Split('.').Select(int.Parse).ToArray();

            for (i = 0; i < Math.Max(first.Count(),second.Count()); i++)
            {
                int v1 = i >= first.Count() ? 0 : first[i];
                int v2 = i >= second.Count() ? 0 : second[i];

                if (v1 > v2) return 1;
                if (v1 < v2) return -1;
            }
            return 0;
    }
}
