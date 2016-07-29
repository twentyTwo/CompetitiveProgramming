int guess(int num);

class Solution {
public:
    int guessNumber(int n) {
      
        long long int low, high, mid;
        
        if(guess(1)==0) return 1;
        if(guess(n)==0) return n;
        
        low=1;
        high = n;
        mid = (n+1)/2;
        while(guess(mid)!=0)
        {
           if(guess(mid)==-1){
               high = mid;
               mid = (low+ high)/2;
           }
           else{
               low=mid;
               mid = (low+high)/2;
           }
        }
        return mid;
        
    }
};
