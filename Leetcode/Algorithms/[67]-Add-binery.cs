public class Solution {
    public string AddBinary(string a, string b) {
            var carry = 0;
            var result = new List<int>();
            var highLength = a.Length > b.Length ? a.Length : b.Length;


            var aArray = new string(a.ToCharArray().Reverse().ToArray());
            var bArray = new string(b.ToCharArray().Reverse().ToArray());

            for (var i = 0; i < highLength; i++)
            {
                var ai = i > a.Length - 1 ? 0 : aArray[i] - 48;
                var bi = i > b.Length - 1 ? 0 : bArray[i] - 48;

                var curDigit = ai + bi;

                switch (curDigit + carry)
                {
                    case 3:
                        carry = 1;
                        curDigit = 1;
                        break;
                    case 2:
                        carry = 1;
                        curDigit = 0;
                        break;
                    case 1:
                        carry = 0;
                        curDigit = 1;
                        break;
                    default:
                        carry = 0;
                        curDigit = 0;
                        break;
                }
                result.Add(curDigit);
            }

            if (carry == 1)
            {
                result.Add(1);
            }

            result.Reverse();
            return string.Join(string.Empty, result.ToArray());
    }
}
