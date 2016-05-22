#include <stdio.h>

int diffDigit[5001];

int diffDig(int N){
    int digits[10], i, c;

    for(i=0; i<=9; i++) digits[i] = 0;

    while(N){
       c = N%10;
       N/=10;
       digits[c]++;
       if(digits[c]>1) return 1;
    }

    return 0;

}

int main()
{
    int i, M, N;
    diffDigit[0] = 0;
    for(i=1; i<=5000; i++) diffDigit[i] = diffDigit[i-1]+ diffDig(i);

    while(scanf("%d %d", &M, &N)!=EOF){
        printf("%d\n", N-M+1-diffDigit[N]+diffDigit[M-1]);
    }

    return 0;
}




