public class Solution {
    public bool WordPattern(string pattern, string str) {
       var dict = new Dictionary<char, string>();

            var strList = str.Split(' ');
            if (pattern.Length != strList.Count())
            {
                return false;
            }
            else
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    if (dict.ContainsKey(pattern[i]))
                    {
                        var val = dict[pattern[i]];
                        if (val != strList[i])
                        {
                            return false;
                        }
                    }
                    else if (dict.ContainsValue(strList[i]))
                    {
                        var key = dict.FirstOrDefault(x => x.Value == strList[i]).Key;
                        if (key != pattern[i])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        dict.Add(pattern[i], strList[i]);
                    }
                }
            }
           
            return true;
    }
}
