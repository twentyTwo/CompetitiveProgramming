public class Solution {
    public int FindComplement(int num) {
        int[] bitArray = new int[32]; 

            for (int i = 0; i < 31; i++)
            {
                int bit = num & 1;
                bitArray[i] = bit;
                num = num >> 1;
            }

            bool noOneAppears = true;
            int number=0;
            for (int i = 31; i >=0; i--)
            {
                if(bitArray[i]==0 && noOneAppears) continue;
                else
                {
                    noOneAppears = false;
                    number= number + (1-bitArray[i]) * (1 << i);
                }
            }
            return number;
    }
}
