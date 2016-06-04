public class Solution {
    public string ReverseWords(string s)
    {
        return String.IsNullOrWhiteSpace(s) ? String.Empty : String.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray().Reverse());
    }
}
