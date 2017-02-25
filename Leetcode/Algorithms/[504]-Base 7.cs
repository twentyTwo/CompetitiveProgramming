public class Solution {
    public string ConvertToBase7(int num) {
            if (num == 0) return "0";

            bool isNegative = false;
            if (num < 0)
            {
                isNegative = true;
                num = -num;
            }

            var list = new List<int>();
            while (num>0)
            {
                var mod=num % 7;
                num = num/7;
                list.Add(mod);
            }

            string str = String.Empty;
            

            for (int i = list.Count - 1; i >= 0; i--)
            {
                str += list[i].ToString();
            }

            

            return isNegative ? "-"+str : str; 
    }
}
