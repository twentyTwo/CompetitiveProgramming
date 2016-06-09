public class Solution {
    public string CountAndSay(int n) {
        int cnt = 0;
            var numList = new List<string> { "1", "11" }; // 1st two numbers
            for (int i = 2; i < n; i++) // Starting from the 3rd number
            {
                var prevNumber = numList[i - 1];
                var prevDigit = prevNumber[0];
                var newNum = String.Empty;

                for (var j = 1; j <= prevNumber.Length; j++)
                {
                    var currentDigit = j<prevNumber.Length ? prevNumber[j] : '\0';

                    if (currentDigit == prevDigit) cnt++;
                    else
                    {
                        cnt++;
                        newNum += cnt.ToString() + prevDigit;
                        cnt = 0;
                        prevDigit = currentDigit;
                    }
                }
                numList.Add(newNum);

            }
            return numList[n - 1].ToString();
    }
}
