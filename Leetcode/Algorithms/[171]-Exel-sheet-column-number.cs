public class Solution {
    public int TitleToNumber(string s) {
        int p = s.Length - 1;
        double sum = s.Select(t => t - 64).Select(num => num * Math.Pow(26, p--)).Sum();
        return Convert.ToInt32(sum);
    }
}
