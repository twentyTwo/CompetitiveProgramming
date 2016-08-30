public class Solution {
    public char FindTheDifference(string s, string t) {
        foreach (var l in s)
        {
            var index = t.IndexOf(l);
            t = t.Remove(index, 1);
        }
        return char.Parse(t);
    }
}
