public class Solution {
    public int LongestPalindrome(string s) {
        var CharCount = new int[52];
        int sum = 0;
        bool isASingleCharacterExists = false;

        foreach (var e in s)
        {
            var index = e >= 65 && e <= 90 ? e - 65 : e - 71;
            CharCount[index] += 1;
        }

        foreach (var c in CharCount)
        {
            if (c % 2 == 0) sum += c;
            
            if (c % 2 == 1)
            {
                sum += c - 1;
                isASingleCharacterExists = true;
            }
        }

        return isASingleCharacterExists ? sum + 1 : sum;
    }
}
