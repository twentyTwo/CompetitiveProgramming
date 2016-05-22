#include<stdio.h>

int NumList[100001];
int AnsRow[100001];

int main(){
	long int maxValue, N, S, i, l, isEnd, add;
	while (scanf("%d %d", &N, &S) != EOF){
		i = 0;
		isEnd = 0;
		add = 0;
		maxValue = -1;
		NumList[0] = AnsRow[0] = 0;
		for (i = 1; i <= N; i++){
			scanf("%d", &NumList[i]);
			AnsRow[i] = NumList[i];
			add += AnsRow[i];
			maxValue = maxValue>NumList[i] ? maxValue : NumList[i];
		}
		if (add < S) {
			printf("0\n");
			continue;
		}

		if (maxValue >= S) {
			printf("1\n");
			continue;
		}

		for (l = 1; l <= N; l++){ 
			for (i = l; i <= N; i++){
				AnsRow[i] = AnsRow[i] + NumList[i - l];
				if (AnsRow[i] >= S) {
					printf("%d\n", l + 1);
					isEnd = 1;
					break;
				}
			}
			if (isEnd) break;
		}
	}
	return 0;
}