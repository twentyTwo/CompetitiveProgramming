public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> sumDigit = new List<int>();
            int carry = 0;
            int curDigit = digits[digits.Length - 1] + 1;
            if (curDigit > 9)
            {
                carry = 1;
                curDigit -= 10;
            }
            
            sumDigit.Add(curDigit);

            for (int i = digits.Length - 2; i >= 0; i--)
            {
                curDigit = carry + digits[i];
                if (curDigit > 9)
                {
                    carry = 1;
                    curDigit -= 10;
                }
                else{
                    carry=0;
                }
                sumDigit.Add(curDigit);
            }

            if (carry == 1)
            {
                sumDigit.Add(1); 
            }

            sumDigit.Reverse();

            return sumDigit.ToArray();
    }
}
