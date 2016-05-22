#include <stdio.h>
#include <stdlib.h>
#define ll long long int

/*Defined library here */
int cmpfunc(const void * a, const void * b){return (*(ll*)a - *(ll*)b);}

ll placesA[10000001];
ll placesB[10000001];
ll result[10000001];

/*
2
5 2
4 5 6 7 8
5 6 7 8 9
5 0
7 6 7 8 7
4 5 6 7 8
*/

int main(){
	int tc;
	ll temp;
	ll i, ans, nPlace, canIgnored, sum;

	int t = 1;
	scanf("%d", &tc);

	for (t = 1; t <= tc; t++){
		sum = 0;

		scanf("%lld %lld", &nPlace, &canIgnored);

		for (i = 0; i < nPlace; i++) scanf("%lld", &placesA[i]);
		

		for (i = 0; i < nPlace; i++)
		{
			scanf("%lld", &temp);
			result[i] = temp - placesA[i];
		}

		qsort(result, nPlace, sizeof(ll), cmpfunc);

		for (i = 0; i < nPlace; i++){

			if (canIgnored>0 && result[i]<=0){
				canIgnored--;
				continue;
			}
			sum += result[i];		
		}

		sum>0 ? printf("Case %d: %lld\n", t, sum) : printf("Case %d: No Profit\n", t);
	}


	return 0;
}
