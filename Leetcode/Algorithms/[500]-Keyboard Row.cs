public class Solution {
    public string[] FindWords(string[] words) {
        
            string lower = "zxcvbnm";
            string middle = "asdfghjkl";
            string upper = "qwertyuiop";

            List<string> ansList = new List<string>();


            foreach (var word in words)
            {
                var wordSmall = word.ToLower();
                bool isFound = wordSmall.All(x => lower.Contains(x)) || wordSmall.All(x => middle.Contains(x)) || wordSmall.All(x => upper.Contains(x));
                if (isFound)
                {
                    ansList.Add(word);
                }

            }
            return ansList.ToArray();
    }
}
