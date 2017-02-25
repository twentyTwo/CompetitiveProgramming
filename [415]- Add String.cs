public class Solution {
        public string AddStrings(string num1, string num2)
        {
            string result = String.Empty;

            num1 = Reverse(num1);
            num2 = Reverse(num2);

            var len = num1.Length > num2.Length ? num2.Length : num1.Length;

            int c = 0;

            for (int i = 0; i < len; i++)
            {
                int a = int.Parse(num1[i].ToString());
                int b = int.Parse(num2[i].ToString());

                int r = a + b + c;

                if (r > 9)
                {
                    r = r - 10;
                    c = 1;
                }
                else
                {
                    c = 0;
                }
                
                result += r.ToString();
            }

            if (num1.Length > num2.Length)
            {
                for (int i = len; i < num1.Length; i++)
                {
                    int r = (c + int.Parse(num1[i].ToString()));
                    if (r > 9)
                    {
                        r = r - 10;
                        c = 1;
                    }
                    else
                    {
                        c = 0;
                    }

                    result += r.ToString();
                } 
            }
            else if (num2.Length > num1.Length)
            {
                for (int i = len; i < num2.Length; i++)
                {
                    int r = (c + int.Parse(num2[i].ToString()));
                    if (r > 9)
                    {
                        r = r - 10;
                        c = 1;
                    }
                    else
                    {
                        c = 0;
                    }
                    result += r.ToString();
                }
            }

            if (c == 1)
            {
                result += "1";
            }

            return Reverse(result);


        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
}
