#include <stdio.h>
/* 
	Tips: Subtracting a time from 12:00 i.e. 11:60 gives the mirror time. 
*/
int main()
{
    int tc, h, m, mh, mm;
    scanf("%d", &tc);
    
    while(tc--){
        scanf("%d : %d", &h, &m);
        mm = 60 - m;
        mh = 11 - h;
        if(mm==60) { mh+=1; mm=0; }
        if(mh<=0) mh+=12;

        printf("%02d:%02d\n",mh,mm);
    }

    return 0;
}
