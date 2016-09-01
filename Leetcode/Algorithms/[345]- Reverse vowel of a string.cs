public class Solution {
    public string ReverseVowels(string s) {
            int i = 0;
            var ans = new StringBuilder();
            var vowels = new List<char>(){ 'a','e','i','o','u','A','E','I','O','U'};

            var vowelList  = s.Where(l => vowels.Contains(l)).ToList();
            i = vowelList.Count() - 1;

            foreach (var l in s)
            {
                ans.Append(vowels.Contains(l) ? vowelList[i--] : l);
            }

            return ans.ToString();
    }
}
