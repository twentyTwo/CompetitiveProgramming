public class Solution {
    public bool IsPowerOfFour(int num) {
        if( num<0 ||num==0 || num==3 || num==2 ) return false;
        if(num==1) return true;
        while(num>1){
            if(num%4!=0) return false;
            num = num/4;
        }
        return true;
        
    }
}
