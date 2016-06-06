public class Solution {
    public int LengthOfLastWord(string s) {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            string[] str = s.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            int n = str.Count();
            return str[n-1].Count();
    }
}
